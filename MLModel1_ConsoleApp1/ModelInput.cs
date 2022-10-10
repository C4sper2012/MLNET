using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLModel1_ConsoleApp1
{
    /// <summary>
    /// model input class for MLModel1.
    /// </summary>
    #region model input class
    public class ModelInput
    {
        [ColumnName(@"Text")]
        public string Text { get; set; }

        [ColumnName(@"IsRacist")]
        public bool IsRacist { get; set; }

    }

    #endregion
}
