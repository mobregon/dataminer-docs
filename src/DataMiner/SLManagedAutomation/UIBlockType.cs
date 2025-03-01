﻿namespace Skyline.DataMiner.Automation
{
	/// <summary>
	/// Specifies the of a dialog box item in an interactive Automation script.
	/// </summary>
	/// <remarks>
	/// <para>Refer to <see href="xref:UIBlockTypesOverview">UIBlockType overview</see>.</para>
	/// </remarks>
	public enum UIBlockType
	{
		/// <summary>
		/// Undefined.
		/// </summary>
		Undefined = 0,
		/// <summary>
		/// Static text.
		/// </summary>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.StaticText;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		StaticText = 1,
		/// <summary>
		/// Text box.
		/// </summary>
		/// <remarks>
		/// <para>From DataMiner 9.5.3 onwards, this control can be used with a ‘WantsOnChange’ property, which prevents updates being sent after a single character is changed in a text box. See WantsOnChange.</para>
		/// </remarks>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.TextBox;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		TextBox = 2,
		/// <summary>
		/// Drop-down list.
		/// </summary>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.DropDown;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		DropDown = 3,
		/// <summary>
		/// Button.
		/// </summary>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.Button;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		Button = 4,
		/// <summary>
		/// Variable.
		/// </summary>
		Variable = 5,
		/// <summary>
		/// Text displaying the value of a parameter.
		/// </summary>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.Parameter;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		Parameter = 6,
		/// <summary>
		/// Check box.
		/// </summary>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.CheckBox;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		CheckBox = 7,
		/// <summary>
		/// Calender control.
		/// </summary>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.Calendar;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		Calendar = 8,
		/// <summary>
		/// Item that displays a time value.
		/// </summary>
		/// <remarks>
		/// <code>From DataMiner 9.5.3 onwards, additional classes are available to define controls to select the date and/or time. See AutomationConfigOptions.</code>
		/// </remarks>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.Time;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		Time = 9,
		/// <summary>
		/// Global settings.
		/// </summary>
		GlobalSettings = 10,
		/// <summary>
		/// Check box list.
		/// </summary>
		/// <example>
		/// <code>
		/// UIBlockDefinition blockItem = new UIBlockDefinition();
		/// blockItem.Type = UIBlockType.CheckBoxList;
		/// 
		/// MyDialogBox.AppendBlock(blockItem);
		/// </code>
		/// </example>
		CheckBoxList = 11,
		/// <summary>
		/// Numeric.
		/// </summary>
		/// <remarks>
		/// <para>Allows you to define a newly created dialog box item displaying a numeric value.</para>
		/// <para>The initial value has to have the following format: [DoubleValue];[Boolean];[SelectedDiscreetString]</para>
		/// <list type="unordered">
		/// <item><description>DoubleValue: Value of the numeric box.</description></item>
		/// <item><description>Boolean: Indicates whether the discrete check box is selected (true) or cleared (false).</description></item>
		/// <item><description>SelectedDiscreetString: selects the discrete parameter with that exact name in case multiple discrete parameters are defined.</description></item>
		/// </list>
		/// <para>Example: <code>string sel_numericValue = "10;true;Discreet 2";</code></para>
		/// <para>If you want a check box with one or more discrete values, then use the Extra property to specify a list of discrete values (separated by semicolons). If you only want a numeric box and no check box, then leave the Extra property empty. In that case, just set the initial value to the DoubleValue.</para>
		/// <para>If you set the WantsOnChange property to “true”, then both the check box and the discrete combo box will trigger a change.</para>
		/// <para>Optionally you can provide a RangeHigh (maximum value), a RangeLow (minimum value), a RangeStep (increment or decrement steps) and the number of decimals.</para>
		/// <para>Note: From DataMiner 9.5.5 onwards, you can specify the WantsOnChange property to have a small delay before a change is triggered by the numeric box itself, in order to avoid updates being sent as soon as a single character is changed in the numeric box. See WantsOnChange.</para>
		/// </remarks>
		/// <example>
		/// <code>
		/// UIBlockDefinition numericBlock = new UIBlockDefinition();
		/// numericBlock.Type = UIBlockType.Numeric;
		/// numericBlock.InitialValue = "10;true;Discreet 2";
		/// numericBlock.DestVar = "num";
		/// numericBlock.WantsOnChange = true;
		/// numericBlock.Row = 0;
		/// numericBlock.Column = 1;
		/// numericBlock.HorizontalAlignment = "Center";
		/// numericBlock.VerticalAlignment = "Top";
		/// numericBlock.RangeHigh = 300;
		/// numericBlock.RangeLow = 5;
		/// numericBlock.RangeStep = 5;
		/// numericBlock.Decimals = 6;
		/// numericBlock.Extra = "Discreet 1;Discreet 2;Discreet 3";
		/// 
		/// uib.AppendBlock(numericBlock);
		/// </code>
		/// </example>
		Numeric = 12,
		/// <summary>
		/// Executable.
		/// </summary>
		Executable = 13,
		/// <summary>
		/// Radio button list.
		/// </summary>
		/// <remarks>Available from DataMiner 9.6.6 onwards (RN 21475).</remarks>
		RadioButtonList = 14,
		/// <summary>
		/// Password input box.
		/// </summary>
		/// <remarks>Available from DataMiner 9.6.6 onwards (RN 21518).</remarks>
		PasswordBox = 15,
		/// <summary>
		/// File selector.
		/// </summary>
		/// <remarks>Available from DataMiner 10.0.2 onwards (RN 23950).</remarks>
		FileSelector = 16,
		/// <summary>
		/// Tree view control.
		/// </summary>
		/// <remarks>Available from DataMiner 10.0.10 onwards.</remarks>
		TreeView = 17
	}
}