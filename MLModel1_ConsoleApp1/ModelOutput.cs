using Microsoft.ML.Data;

namespace MLModel1_ConsoleApp1
{
    /// <summary>
    /// model output class for MLModel1.
    /// </summary>
    #region model output class
    public class ModelOutput
    {
        [ColumnName(@"Text")]
        public float[] Text { get; set; }

        [ColumnName(@"IsRacist")]
        public bool IsRacist { get; set; }

        [ColumnName(@"Features")]
        public float[] Features { get; set; }

        [ColumnName(@"PredictedLabel")]
        public bool PredictedLabel { get; set; }

        [ColumnName(@"Score")]
        public float Score { get; set; }

        [ColumnName(@"Probability")]
        public float Probability { get; set; }

    }

    #endregion
}
