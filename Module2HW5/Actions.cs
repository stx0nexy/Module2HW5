using Module2HW5.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5
{
    public class Actions : IActions
    {
        private readonly ILogger _logger;

        public Actions(ILogger logger)
        {
            _logger = logger;
        }

        public bool Method_1()
        {
            _logger.LogInfo($"Start method: {nameof(Method_1)}");
            return true;
        }

        public bool Method_2()
        {
            throw new BusinessException($"Skipped logic in method");
        }

        public bool Method_3()
        {
            throw new Exception("I broke a logic");
        }
    }
}
