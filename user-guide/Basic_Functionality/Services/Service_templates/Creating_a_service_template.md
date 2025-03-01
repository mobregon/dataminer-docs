---
uid: Creating_a_service_template
---

# Creating a service template

To create a new service template, right-click a view in the Surveyor, and select *New \> Service template*.

This will open a service template card, with the following 9 tabs:

| Service template card tab | Description                                                                                                                                                                                                                                                |
|---------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| General                   | This tab contains the general characteristics of a service template. See [Specifying general characteristics of a service template](#specifying-general-characteristics-of-a-service-template).                                                            |
| Input data                | In this tab, you can add and configure the template’s input data. See [Specifying the input data for a service template](#specifying-the-input-data-for-a-service-template).                                                                               |
| Groups                    | In this tab, you can specify groups for child elements in the service template. See [Using groups of service template child elements](#using-groups-of-service-template-child-elements).                                                                   |
| Child elements            | In this tab, you can specify which child elements should be included in the service template. See [Creating child elements in service templates](#creating-child-elements-in-service-templates).                                                           |
| Generated service         | In this tab, you can determine several characteristics of the services generated by the service template. See [Determining the characteristics of generated services](#determining-the-characteristics-of-generated-services).                             |
| RCA                       | In this tab, you can indicate the relationship between the elements in the generated services. See [Specifying root cause information in a service template](#specifying-root-cause-information-in-a-service-template).                                    |
| Generated SLA             | In this tab, you can configure a possible SLA for the generated services. See [Specifying an SLA in a service template](#specifying-an-sla-in-a-service-template).                                                                                         |
| View                      | In this tab, you can specify the destination view for the template and the services it generates. See [Specifying the destination view of a service template](#specifying-the-destination-view-of-a-service-template).                                     |
| Advanced                  | In this tab, you can specify the order in which child elements and input data will be selected when the service is generated. See [Specifying the order to select data in a service template](#specifying-the-order-to-select-data-in-a-service-template). |

> [!NOTE]
> To configure the service template, you do not have to follow a fixed order. You can for instance first configure a child element in the *Child elements* tab, then configure input data in the *Input data* tab, and then change the child element you created earlier to use this input data.

## Specifying general characteristics of a service template

In the *General* tab of a service template card, enter the following information:

- **Template name**: The name of the service template.

- **Template description**: A short description of the template

In addition, two advanced options are available in the *General* tab:

- Select *Require confirmation before applying* to ensure that the user has to confirm before the service template is applied.

- Select *Auto execute template when new elements have been added in the system* to automatically apply the service template when a new element is added in the DMS.

> [!NOTE]
> If the service template is automatically applied when a new element is added, the *Background Tasks* window will appear so you can follow the progress.

- Select *Keep duplicates of generated services when re-applying* to make sure that, if this service template is re-applied, any copies of services that were generated when it was applied earlier are not deleted.

## Specifying the input data for a service template

In the *Input data* tab of a service template card, you can add and configure the input data that will either have to be specified by the user applying the template, or that will be automatically determined from parameters.

To add input data:

1. Click the *Add input data* button at the bottom of the card.

2. For each entry:

    1. In the *Name* column, specify a name.

    2. In the *Title* column, specify a description. This description is the text that will be shown when you use the input data elsewhere.

    3. In the *Type* column, select one of the three options: *User Input Text*, *Table Row Index*, or *Fixed Value*.

    4. In the *Details* column:

        - If you selected *User Input Text*, optionally indicate whether a valid element name is required, or if “N/A” can be used to indicate an empty value.

        - If you selected *Table Row Index*, click *Edit* to specify a table parameter and optionally add a filter mask.

        - If you selected *Fixed Value*, specify the fixed value.

        > [!NOTE]
        > While specifying the User Input Text, Table Row Index or Fixed Value, it is possible to refer to other input data or to child elements specified elsewhere in the service template.

If you added any input data that you want to delete later, you can delete them with the X in the *Delete* column.

> [!NOTE]
> - You can choose both monitored and unmonitored parameters as input data for the service. The latter can be used to include information that is important for the user, even though it does not necessarily have an impact on the service state.
> - By default, the services created by a service template will be added on the DMA hosting the majority of the child elements. In case there are no child elements, the services are added on the DMA where the service template is executed. However, you can force the selection of a specific DMA by adding an input data field with the name *:forceDMA* and the type *Fixed Value*, and specifying the DMA ID in the *Details* column.

## Using groups of service template child elements

Go to the *Groups* tab of a service template card to create groups for the child elements of the service template. For these groups, you can then define conditions for inclusion or exclusion of elements or services, or set a maximum severity for child elements.

To add a group:

1. Click the *Add New Group* button at the bottom of the tab.

2. In the *Name* column, specify a name for the group.

3. In the *Edit* column, click the *Edit* button to configure the group further:

    - In the *Conditions* section of the *Edit group* window, two options can be selected:

        - To only include the group based on certain conditions, select *Dynamically include* or *Dynamically exclude* and add a trigger with the *Add trigger* button.

        - To limit the influence of the group on the service alarm severity, select *While included, influence overall service alarm severity when*, and add a trigger with the *Add trigger* button.

    - In the *Advanced* section of the *Edit Group* window, three configuration options are available:

        - To set a maximum severity for included elements in the group, select a severity in the drop-down list next to *Maximum severity on included element*.

        - To set a maximum severity for elements in the group that are not used, select a severity in the drop-down list next to *Maximum severity on element not used*.

        - To indicate a parent group for the group, select it in the *Parent Group* drop-down list.

        > [!NOTE]
        > For more information on service item statuses such as “included” and “not used”, see [DATA](xref:Service_card_pages#data).

If you have added any groups that you would like to delete, use the X in the *Delete* column of these groups.

To include child elements in a group:

- When editing a child element, select a parent group at the top of the *Edit Child Element* window. See [Creating child elements in service templates](#creating-child-elements-in-service-templates).

## Creating child elements in service templates

In the *Child elements* tab of a service template card, you can determine which elements or services will be included in the services generated by the service template. You can also include only certain parameters, or specify conditions for the inclusion and exclusion of elements and services.

> [!NOTE]
> A “child element” does not necessarily have to indicate an element. The term is also used to refer to a service, or to a set of parameters of an element.

To add a child element:

1. Click the *Add child element* button at the bottom of the *Elements* section.

2. In the *Title* column, specify the display name for the child element.

3. Click the *Edit* button to specify the settings for a child element.

4. In the *Edit child element* window, configure the child element:

    1. In the *General* section, you can optionally:

        - Select a parent group that was created in the *Groups* tab earlier.

        - Specify an alias for the element, if necessary by referring to other input data or child elements.

    2. In the *Element selection method* section, choose one of the following four options:

        - Select *Fixed element*, and select the element from the drop-down list.

        - Select *Fixed service*, and select the service from the drop-down list.

        - Select *Templated element*, and indicate a *Protocol* and *Element name mask*. Optionally, click *Add alternative* to add an additional protocol and element name mask. Several alternatives can be added. To remove one of the alternatives, click the *x* icon to the right of it.

        - Select *Templated service*, and specify a *service name mask*.

            > [!NOTE]
            > For templated elements and services, you can also select several options at the top of the *Templated element* or *Templated service* section:
            > - Whether the element or service can be reused.
            > - Whether the element or service is optional. In that case, the service will still be created even if there is no match, but the element or service will not be included.
            > - Whether all elements or services matching the protocol name and/or element name mask should be included in the generated service.

    3. If you chose a fixed element or templated element, in the *Included Parameters* section, indicate what parameters should be included:

        - Select *All parameters*, or

        - Select *Some parameters*, and click *Select parameters*.

            In the *Select parameters* window, select the checkbox for any parameters you want to include.             If you want to add a parameter based on placeholders, click *Add masked parameter,* and specify the parameter name mask. To do so:

            - In the *Name mask* box, use the drop-down list on the right to select the placeholders determining the parameter name. Four options are available: *Use regular expression*, *Input data*, *Child element*, or *Custom element*.

            - If at least one filter has been specified, optionally select *Only search monitored parameters*.

            - For a matrix or table parameter, optionally specify particular inputs/outputs or rows in the box underneath *Included rows/inputs/outputs*, with wildcards if necessary.

            > [!NOTE]
            > If you include a table parameter using placeholders, you can use wildcards to dynamically include only the table rows with a matching display key. If you do not want the set of rows to change dynamically, but only want to include the first match found when the service is generated, use the prefix “!1st!” before the wildcard.
            >
            > E.g.: *!1st!\*\_BBC\_\**

    4. In the *Conditions* section, two options can be selected:

        - To only include a child item based on certain conditions, select *Dynamically include* or *Dynamically exclude* and add a trigger with the *Add trigger* button.

        - To limit the influence of the child element on the service alarm severity, select *While included, influence overall service alarm severity when*, and add a trigger with the *Add trigger* button.

        > [!NOTE]
        > - Like in a service, inclusion and exclusion can be triggered based on a parameter state, alarm state or element state, or on whether the element is part of the active connectivity chain. However, for the latter, connectivity must be configured on the DMA. See [Conditionally including an element in a service](xref:Conditionally_including_an_element_in_a_service).
        > - For a matrix parameter, to create a condition where a matrix crosspoint is connected or disconnected, create a trigger on parameter value for the matrix parameter, in the trigger condition use *==* or *\<\>* respectively, and specify the input/output names in the text value, separated by a comma (e.g. “input A, output B”).

    5. In the *Advanced* section, optionally set a maximum severity for elements that are included or not used.

        > [!NOTE]
        > For more information on service item statuses such as “included” and “not used”, see [DATA](xref:Service_card_pages#data).

    > [!NOTE]
    > When specifying a templated element or service name mask, or a name mask for parameters, you can use a regular expression. To do so, select *Use regular expression* in the drop-down list on the right. Once you have done this, an extra item will appear in the drop-down list, *Regular Expression Options*, which allows you to indicate if casing can be ignored and if the regular expression is required to match the entire input.

To add a condition for all child elements:

- Click the *Add condition* button at the bottom of the *Child Elements* tab.

To remove a child element from the service template:

- Click the X in the *Delete* column for that child element.

## Determining the characteristics of generated services

To determine general characteristics of services generated by a service template, such as their names, Visual Overview, and alarm templates, go to the *Generated service* tab of the service template card.

The following settings can be configured in this tab:

- To determine the name of the generated services, under *Generated service name*, click the downward triangle to enter placeholders. You can combine these with fixed text in the *Generated service name* box.

    > [!NOTE]
    > If you do not specify a name, the user will have to specify it when applying the template.

- To determine the description of the generated services, under *Generated service description*, click the downward triangle to enter placeholders. You can combine these with fixed text in the *Generated service description* box.

- To indicate whether timeouts are included in the alarm status of the generated services, either clear or select *Include timeouts in service alarm status*.

- To determine which Visio file will be used on the Visual Overview pages of the service card, specify the file under *Visio File*. If necessary, click the downward triangle to the right of the box to enter placeholders.

    > [!NOTE]
    > To upload a ZIP or VDX file, simply fill in the file name, without the file extension. To use a VSDX file, specify the file name with the .vsdx extension.

- To determine the default page of the service’s Visio file, specify the page under *Default Page*. If necessary, click the downward triangle to the right of the box to enter placeholders.

- To specify a service protocol for the generated services, select a service protocol in the drop-down list under *Protocol* or (prior to DataMiner 9.6.8) *Definition*.

- To specify an alarm template for the generated services, specify the template in the box under *Alarm Template*.

- To specify a trend template for the generated services, specify the template in the box under *Trend Template*.

    > [!NOTE]
    > You can only specify an alarm or trend template after you have specified a service protocol.

- To add custom service properties to the generated services:

    1. Click *Add service property*.

    2. Specify a *Property name*.

    3. Specify the *Property value*, if necessary by clicking the downward triangle to enter placeholders.

## Specifying root cause information in a service template

In the *RCA* tab of a service template card, you can indicate the relationship between the elements in the service, so that alarms will contain root cause information.

To determine an RCA chain in a service template:

1. In the *RCA* tab, click the button *Start configuring RCA connectivity chain*.

2. In the box that appears in the middle of the tab, select the child element you want to start from.

3. Right-click the box and:

    - Select *Add parent* to add a child element higher in the chain.

    - Select *Add child* to add a child element lower in the chain.

4. In the additional box, select the correct child element.

5. Repeat from step 3 until all the necessary elements have been added to the chain.

    If you add an element too many, you can delete it again from the chain by right-clicking the box and selecting *Delete*.

> [!NOTE]
> You can only determine an RCA chain if a service template has at least two child elements.

> [!TIP]
> See also:
> [Working with the Connectivity Editor](xref:Working_with_the_Connectivity_Editor)

## Specifying an SLA in a service template

In a service template, it is possible to specify that an SLA should be generated along with its generated services.

To do so:

1. Go to the *SLA* tab of the service template card.

2. Select *Create SLA*.

3. To create custom properties for the SLA, in the *Properties* section, click *Add SLA property*.

> [!NOTE]
> If an existing service template is updated to include an SLA element, while it did not include one before, an SLA element will be created. Similarly, if an existing service template is updated to no longer include an SLA element, the SLA element will be removed when the service template is applied.

> [!TIP]
> See also:
> [DMS Business Intelligence](xref:sla#dms-business-intelligence)

## Specifying the destination view of a service template

In a service template you can specify both the destination view of the generated services as that of the service template itself. Both are done in the *View* tab of the service template card.

To determine the destination view for the service template:

- Select one or more views in the section *Destination view template*.

To determine the destination view for the generated services, in the *Destination view generated services* section, choose one of the following three options:

- To generate the services in a predetermined view, select *Fixed view* and select the view in the drop-down list. Only one view can be specified in case a fixed view is used.

- To generate the services in the view where the template is applied, select *View on which template was applied*.

- To specify a view name, select *View by name* and specify the name. You can click the downward triangle to the right of this box to select placeholders. To specify multiple destination views, use a pipe character (“\|”) between the view names.

## Specifying the order to select data in a service template

In some cases, it may be necessary to explicitly specify the order in which child elements and input data will be selected when the service is generated.

When no custom order is configured, the following order is taken automatically:

- Input data without references to child elements

- Child elements

- Input data with references to child elements

To configure a custom order:

1. Go to the *Advanced* tab of the service template.

2. In the *Input order* box, enter the elements and input data, in the format *element:\[child element ID\]* and *data:\[input data name\]*, separated by a “\|” sign.

    Example:

    ```txt
    data:svc|element:1|data:tsid|element:2
    ```

## Example of creating a service template

1. Right-click a view in the Surveyor and choose *New \> Service template*.

2. In the *General* tab, enter the name of the service template under *Template name*, and optionally add a description.

3. Select the *Child elements* tab, and add a child element:

    1. Click *Add child element*.

    2. In *Title*, enter the name of the child element (example: “MsElement”).

    3. Click *Edit* to open the *Edit child element* dialog box.

    4. Select *Templated element*.

    5. Select *Allow element to be reused by multiple services*.

    6. Select the protocol (example: “Microsoft Platform”) and the protocol version (example: “Production”).

    7. Click *OK*.

4. Select the *Input data* tab, and add input data:

    1. Click *Add input data*.

    2. Specify a *Name* and a *Title* (example: “Model”).

    3. Set Type to *Fixed Value*.

    4. In *Details*, open the placeholder selection box, and select *Child elements \> \[ElementTitle\] (example: “MsElement”) \> Parameter*.

    5. In the *Select parameter* dialog box, open the *Parameter* selection box, select the parameter (example: “Model”) from the list, and click *OK*.

5. Still in the *Input Data* tab, add input data again:

    1. Click *Add Input Data*.

    2. Specify a Name and a Title (example: “Process”).

    3. Set Type to *Table Row Index*.

    4. Click *Edit*.

    5. In the *Select Table Parameter* dialog box, specify the Child Element (example: “MsElement”), specify the Parameter (example: “Task Manager”), specify the Filter Mask (example: “SL\*”), and click *OK*.

6. Select the *Child elements* tab, and edit the child element you have created earlier:

    1. Click *Edit* to open the *Edit child element* dialog box.

    2. In the *Included parameters* section, select *Some parameters*, and click *Select parameters*.

    3. Select the parameter you want, e.g. “CPU”, open the placeholder selection box, and select *Input data > Process*.

    4. Select a next parameter, e.g. “Memory Usage”, open the placeholder selection box, and select *Input data > Process*.

    5. Click *Close* to exit the *Select parameters* dialog box.

    6. Click *OK* to exit the *Edit child element* dialog box.

7. Select the *Generated service* tab.

    1. Open the placeholder selection box next to *Generated service name*, and select *Input data \> Model*.

    2. Open the placeholder selection box next to *Generated service name*, and select *Input data \> Process*.

    3. Enter an underscore (“\_”) between *\[data:Model\]* and *\[data:Process\]*.

8. If you do not want SLAs to be created when the service template is applied, select the *Generated SLA* tab, and clear the *Create SLA* option.

9. Click *Save And Close*.

> [!NOTE]
> For an example of how to apply this service template, see [Example of applying a service template](xref:Applying_service_templates#example-of-applying-a-service-template).
>
