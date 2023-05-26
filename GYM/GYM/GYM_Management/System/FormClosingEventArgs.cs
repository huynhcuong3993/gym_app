namespace System
{
    internal class FormClosingEventArgs
    {
        private Action<object, Windows.Forms.FormClosingEventArgs> btnExit_Click;
        private Action<object, FormClosingEventArgs> btnExit_Click1;

        public FormClosingEventArgs(Action<object, Windows.Forms.FormClosingEventArgs> btnExit_Click)
        {
            this.btnExit_Click = btnExit_Click;
        }

        public FormClosingEventArgs(Action<object, FormClosingEventArgs> btnExit_Click1)
        {
            this.btnExit_Click1 = btnExit_Click1;
        }
    }
}