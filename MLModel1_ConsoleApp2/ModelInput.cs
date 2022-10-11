using Microsoft.ML.Data;

namespace MLModel1_ConsoleApp2
{
    public class ModelInput
    {
        [ColumnName(@"Label")]
        public string Label { get; set; }

        [ColumnName(@"ImageSource")]
        public byte[] ImageSource { get; set; }

    }
}
