﻿using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

namespace Foundation.Cms.EditorDescriptors
{
    public class BreadcrumbAlginmentOptionSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var separators = new List<SelectItem>
            {
                new SelectItem() {Text = "Left", Value = "flex-start"},
                new SelectItem() {Text = "Right", Value = "flex-end"},
                new SelectItem() {Text = "Center", Value = "flex-center"},
            };

            return separators;
        }
    }
}
