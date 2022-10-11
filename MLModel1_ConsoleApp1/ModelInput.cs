using Microsoft.ML.Data;

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
