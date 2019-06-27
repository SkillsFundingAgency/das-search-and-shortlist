﻿namespace Sfa.Das.Sas.Shared.Components.ViewModels.Css.Interfaces
{
    public interface ICssViewModel
    {
        ITableCssViewModel Table { get; }
        IUtilitiesCssViewModel UtilitiesCss { get; }
        IDefaultFormCssViewModel FormCss { get; }
        string ClassModifier { get; set; }
        string ClassPrefix { get; }
        string Button { get; }

        string Link { get; }
        string List { get; }
        string ListBullet { get; }
        string ListNumber { get; }
        string SearchList { get; }
        string WarningText { get; }
        string HeadingMedium { get; }
        string HeadingLarge { get; }
        string HeadingXLarge { get; }
        string HeadingSmall { get; }
        string HeadingXSmall { get; }

        string Details { get; }
        string DetailsSummary { get; }
        string DetailsSummaryText { get; }
        string DetailsText { get; }
        string VisuallyHidden { get; }
    }
}
