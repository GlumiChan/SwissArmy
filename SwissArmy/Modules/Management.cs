using System.Collections.Generic;
using System.Reflection;

namespace SwissArmy.Modules
{
    public class Management<T>
    {
        private Management() { }
        private Dictionary<UserDialog, bool> dialogs = new Dictionary<UserDialog, bool>();
        private List<object> paramList = new List<object>();

        public void RunModule()
        {
            if (!FillAnsweres())
            {
                return;
            }
            MethodInfo addMethod = typeof(T).GetMethod("Run");

            object result = addMethod.Invoke(this, paramList.ToArray());
        }

        public void AddDialog(bool req, string title, string msg, string def = "")
        {
            dialogs.Add(new UserDialog(title, msg, def), req);
        }
        private bool FillAnsweres()
        {
            foreach (UserDialog dialog in dialogs.Keys)
            {
                string response = dialog.def;
                response = dialog.GetInput();
                if (dialogs[dialog] == true && response.Trim(' ') == dialog.def)
                {
                    return false;
                }
                paramList.Add(response);
            }
            return true;
        }
        public static Management<T> InitModule()
        {
            Management<T> instance = new Management<T>();
            return instance;
        }
    }
}