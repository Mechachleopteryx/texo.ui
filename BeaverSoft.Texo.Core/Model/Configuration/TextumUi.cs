﻿namespace BeaverSoft.Texo.Core.Model.Configuration
{
    public partial class TextumUi
    {
        private string prompt;
        private bool showWorkingPathAsPrompt;

        private TextumUi()
        {
            prompt = string.Empty;
            showWorkingPathAsPrompt = false;
        }

        private TextumUi(TextumUi toClone)
        {
            prompt = toClone.prompt;
            showWorkingPathAsPrompt = toClone.showWorkingPathAsPrompt;
        }

        private TextumUi(Builder builder)
        {
            prompt = builder.Prompt;
            showWorkingPathAsPrompt = builder.ShowWorkingPathAsPrompt;
        }

        public string Prompt => prompt;

        public bool ShowWorkingPathAsPrompt => showWorkingPathAsPrompt;

        public TextumUi SetPrompt(string value)
        {
            return new TextumUi(this)
            {
                prompt = value
            };
        }

        public TextumUi SetShowWorkingPathAsPrompt(bool value)
        {
            return new TextumUi(this)
            {
                showWorkingPathAsPrompt = value
            };
        }

        public Builder ToBuilder()
        {
            return new Builder(this);
        }
    }
}
