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

        private MappingAspectBase _mappingAspect;
        public MappingAspectBase MappingAspect
        {
            get
            {
                if (_mappingAspect == null)
                    _mappingAspect = Aspects.FirstOrDefault(x => x is MappingAspectBase) as MappingAspectBase;

                if (_mappingAspect == null)
                    throw new NotImplementedMappingAspectException();

                return _mappingAspect;
            }
        }



        private LoggingAspectBase _loggingAspect;
        public LoggingAspectBase LoggingAspect
        {
            get
            {
                if (_loggingAspect == null)
                    _loggingAspect = Aspects.FirstOrDefault(x => x is LoggingAspectBase) as LoggingAspectBase;

                return _loggingAspect;
            }
        }

        private IEnumerable<CachingAspectBase> _cachingAspect;
        public IEnumerable<CachingAspectBase> CachingAspect
        {
            get
            {
                if (_cachingAspect == null)
                    _cachingAspect = Aspects.Where(x => x is CachingAspectBase).OfType<CachingAspectBase>();

                return _cachingAspect;
            }
        }

        private bool? _isCachingAspect;
        public bool IsCachingAspect
        {
            get
            {
                if (!_isCachingAspect.HasValue)
                    _isCachingAspect = CachingAspect != null;

                return _isCachingAspect.Value;
            }
        }

        private bool? _isChangingExecuteAspect;
        public bool IsChangingExecuteAspect
        {
            get
            {
                if (!_isChangingExecuteAspect.HasValue)
                    _isChangingExecuteAspect = CachingAspect != null;

                return _isChangingExecuteAspect.Value;
            }
        }

        private IEnumerable<ChangingExecuteAspectBase> _changingExecuteAspects;
        public IEnumerable<ChangingExecuteAspectBase> ChangingExecuteAspects
        {
            get
            {
                if (_changingExecuteAspects == null)
                    _changingExecuteAspects = Aspects.Where(x => x is ChangingExecuteAspectBase).OfType<ChangingExecuteAspectBase>();

                return _changingExecuteAspects;
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

        public ChangingExecuteAspectBase GetChangingExecuteAspect<TInput, TOutput>(Interactor<TInput, TOutput> interactor, TInput input)
        {
            foreach (var item in ChangingExecuteAspects)
            {
                if (item.IsMatch(interactor, input))
                    return item;
            }

            return null;
        }
    }
}
