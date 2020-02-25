﻿namespace Panuon.UI.Silver
{
    #region Loading
    public enum LoadingStyle
    {
        Standard,
        Wave,
        Ring,
        Ring2,
        Classic
    }

    public enum LoadingRunningSpeed
    {
        Normal,
        Quick,
        Slow
    }
    #endregion

    #region WindowX
    public enum HorizontalHeaderAlignment
    {
        Left,
        Stretch,
        Center
    }
    #endregion

    #region Button & RepeatButton
    public enum ButtonStyle
    {
        Standard,
        Outline,
        Hollow,
        Link,
    }

    public enum RepeatButtonStyle
    {
        Standard,
        Outline,
        Hollow,
        Link,
    }

    public enum ToggleButtonStyle
    {
        Standard,
        Outline,
        Hollow,
        Link,
    }

    public enum ClickStyle
    {
        None,
        Sink,
    }

    public enum IconPosition
    {
        Left,
        Top,
    }
    #endregion

    #region TextBlockX
    public enum MatchRule
    {
        First,
        All,
    }
    #endregion

    #region CheckBox
    public enum CheckBoxStyle
    {
        Standard,
        Switch,
        Switch2,
        Switch3,
        Button,
        Selector
    }
    #endregion

    #region NeonLabel
    public enum NeonAnimation
    {
        Notice,
        Marble,
        Barrage,
        Conspicuous,
        FadeNext,
    }
    #endregion

    #region RadioButton
    public enum RadioButtonStyle
    {
        Standard,
        Switch,
        Switch2,
        Switch3,
        Button,
        Selector
    }

    #endregion

    #region ScrollViewer
    public enum ScrollButtons
    {
        None,
        UpDown,
        TopBottom,
        All,
    }
    #endregion

    #region Popup
    public enum ActualPlacement
    {
        Left,
        TopLeft,
        Top,
        TopRight,
        Right,
        BottomRight,
        Bottom,
        BottomLeft,
    }
    #endregion

    #region TreeView
    public enum TreeViewStyle
    {
        Standard,
    }

    #endregion

    #region TabControl
    public enum TabControlStyle
    {
        Standard,
        Card,
    }

    public enum TabControlHeaderStyle
    {
        Standard,
        Expandable,
        Scrollable,
    }
    #endregion

    #region DropDown
    public enum DropDownStyle
    {
        Standard,
        Standard2,
        Smooth,
    }
    public enum DropDownPlacement
    {
        BottomLeft,
        Bottom,
        BottomRight,
        Top,
        TopRight,
        TopLeft,
    }
    #endregion

    #region ComboBoxStyle
    public enum ComboBoxStyle
    {
        Standard,
        Simple
    }
    #endregion

    #region MessageBox
    public enum MessageBoxStyle
    {
        Standard,
        Classic,
        Modern,
    }

    public enum MessageBoxIcon
    {
        None,
        Info,
        Warning,
        Error,
        Success,
        Question,
    }

    public enum DefaultButton
    {
        Unset,
        YesOK,
        NoCancel,
        CancelNo
    }
    #endregion

    #region Calendar

    public enum CalendarSelectionMode
    {
        Date,
        YearMonth,
        Year,
    }

    public enum YearMonthDay
    {
        Year,
        Month,
        Day
    }

    #endregion

    #region GroupBox
    public enum GroupBoxStyle
    {
        Standard,
        Post,
        Footnote
    }

    #endregion

    #region Clock
    public enum HourMinuteSecond
    {
        Hour,
        Minute,
        Second
    }

    public enum TimePeriod
    {
        AM,
        PM
    }

    #endregion

    #region DateTimePicker
    public enum DateTimePickerMode
    {
        DateTime,
        Date,
        Time
    }
    #endregion

    #region Separator
    public enum Alignment
    {
        Left,
        Top,
        Right,
        Bottom,
    }
    #endregion

    #region DrawerPlacement
    public enum DrawerPlacement
    {
        Left,
        Top,
        Right,
        Bottom,
    }
    #endregion

    }
