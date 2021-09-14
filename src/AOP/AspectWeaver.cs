using AOP.Aspects;
using AOP.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases;

namespace AOP
{
    public class AspectWeaver : IAspectWeaver
    {
        public static AspectWeaver Instance { get; private set; }

        private List<IAspect> _aspects = new List<IAspect>();
        public IReadOnlyList<IAspect> Aspects => _aspects;

        private IMappingAspect _mappingAspect;
        public IMappingAspect MappingAspect
        {
            get
            {
                if (_mappingAspect == null)
                    _mappingAspect = Aspects.FirstOrDefault(x => x is IMappingAspect) as IMappingAspect;

                if (_mappingAspect == null)
                    throw new NotImplementedMappingAspectException();

                return _mappingAspect;
            }
        }

        private ILoggingAspect _loggingAspect;
        public ILoggingAspect LoggingAspect
        {
            get
            {
                if (_loggingAspect == null)
                    _loggingAspect = Aspects.FirstOrDefault(x => x is ILoggingAspect) as ILoggingAspect;

                return _loggingAspect;
            }
        }

        private bool? _isChangingExecuteAspect;
        public bool IsChangingExecuteAspect
        {
            get
            {
                if (!_isChangingExecuteAspect.HasValue)
                    _isChangingExecuteAspect = ChangingExecuteAspects.Count() > 0;

                return _isChangingExecuteAspect.Value;
            }
        }

        private IEnumerable<IChangingExecuteAspect> _changingExecuteAspects;
        public IEnumerable<IChangingExecuteAspect> ChangingExecuteAspects
        {
            get
            {
                if (_changingExecuteAspects == null)
                    _changingExecuteAspects = Aspects.Where(x => x is IChangingExecuteAspect).OfType<IChangingExecuteAspect>();

                return _changingExecuteAspects;
            }
        }

        private bool? _isAuthorizingAspect;
        public bool IsAuthorizingAspect
        {
            get
            {
                if (!_isAuthorizingAspect.HasValue)
                    _isAuthorizingAspect = AuthorizingAspects.Count() > 0;

                return _isAuthorizingAspect.Value;
            }
        }

        private IEnumerable<IAuthorizingAspect> _authorizingAspects;
        public IEnumerable<IAuthorizingAspect> AuthorizingAspects
        {
            get
            {
                if (_authorizingAspects == null)
                    _authorizingAspects = Aspects.Where(x => x is IAuthorizingAspect).OfType<IAuthorizingAspect>();

                return _authorizingAspects;
            }
        }

        static AspectWeaver()
        {
            Instance = new AspectWeaver();
        }

        public void AddAspect<T>() where T : class, IAspect
        {
            if (_aspects.Any(x => x is T))
                throw new AspectAlreadyAddedException();

            _aspects.Add(Activator.CreateInstance<T>());
        }

        public IChangingExecuteAspect GetChangingExecuteAspect<TInput, TOutput>(Interactor<TInput, TOutput> interactor, TInput input)
        {
            foreach (var changingExecuteAspect in ChangingExecuteAspects)
            {
                if (changingExecuteAspect.IsMatch(interactor, input))
                    return changingExecuteAspect;
            }

            return null;
        }

        public IAuthorizingAspect GetAuthorizingAspect<TInput, TOutput>(Interactor<TInput, TOutput> interactor, TInput input)
        {
            foreach (var authorizingAspect in AuthorizingAspects)
            {
                if (authorizingAspect.IsMatch(interactor, input))
                    return authorizingAspect;
            }

            return null;
        }
    }
}
