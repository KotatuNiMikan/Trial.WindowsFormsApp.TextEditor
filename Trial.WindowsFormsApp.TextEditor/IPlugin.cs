namespace Trial.WindowsFormsApp.TextEditor
{
    public class DataSavePlugin:IPlugin
    {
        public DataSavePlugin()
        {
        }

        public void InitializePlugin(MainForm mainForm)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IPlugin
    {
        void InitializePlugin(MainForm mainForm);
    }
}