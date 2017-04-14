namespace SwissArmy
{
    public class UserDialog
    {
        public string title { get; private set; }
        public string msg { get; private set; }
        public string def { get; private set; }
        public UserDialog(string _title, string _msg, string _def = "")
        {
            title = _title;
            msg = _msg;
            def = _def;
        }
        public string GetInput()
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox(msg, title, def);
            return result;
        }
    }
}
