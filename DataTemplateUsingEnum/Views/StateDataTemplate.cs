using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Metadata;
using DataTemplateUsingEnum.Models;
using System;
using System.Collections.Generic;

namespace DataTemplateUsingEnum.Views
{
    internal class StateDataTemplate : IDataTemplate
    {
        [Content]
        public Dictionary<string, IDataTemplate> Templates { get; } = new Dictionary<string, IDataTemplate>();

        public IControl Build(object param)
        {
            var key = param.ToString();
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(param));
            }

            return this.Templates[key].Build(param);
        }

        public bool Match(object data)
        {
            var key = data.ToString();

            return data is State &&
                !string.IsNullOrEmpty(key) &&
                this.Templates.ContainsKey(key);
        }
    }
}
