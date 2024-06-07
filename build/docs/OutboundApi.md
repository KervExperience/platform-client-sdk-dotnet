---
title: OutboundApi
---
## PureCloudPlatform.Client.V2.Api.OutboundApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOutboundAttemptlimit**](OutboundApi.html#deleteoutboundattemptlimit) | **Delete** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Delete attempt limits |
| [**DeleteOutboundCallabletimeset**](OutboundApi.html#deleteoutboundcallabletimeset) | **Delete** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Delete callable time set |
| [**DeleteOutboundCallanalysisresponseset**](OutboundApi.html#deleteoutboundcallanalysisresponseset) | **Delete** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Delete a dialer call analysis response set. |
| [**DeleteOutboundCampaign**](OutboundApi.html#deleteoutboundcampaign) | **Delete** /api/v2/outbound/campaigns/{campaignId} | Delete a campaign. |
| [**DeleteOutboundCampaignProgress**](OutboundApi.html#deleteoutboundcampaignprogress) | **Delete** /api/v2/outbound/campaigns/{campaignId}/progress | Reset campaign progress and recycle the campaign |
| [**DeleteOutboundCampaignrule**](OutboundApi.html#deleteoutboundcampaignrule) | **Delete** /api/v2/outbound/campaignrules/{campaignRuleId} | Delete Campaign Rule |
| [**DeleteOutboundContactlist**](OutboundApi.html#deleteoutboundcontactlist) | **Delete** /api/v2/outbound/contactlists/{contactListId} | Delete a contact list. |
| [**DeleteOutboundContactlistContact**](OutboundApi.html#deleteoutboundcontactlistcontact) | **Delete** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Delete a contact. |
| [**DeleteOutboundContactlistContacts**](OutboundApi.html#deleteoutboundcontactlistcontacts) | **Delete** /api/v2/outbound/contactlists/{contactListId}/contacts | Delete contacts from a contact list. |
| [**DeleteOutboundContactlistfilter**](OutboundApi.html#deleteoutboundcontactlistfilter) | **Delete** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Delete Contact List Filter |
| [**DeleteOutboundContactlists**](OutboundApi.html#deleteoutboundcontactlists) | **Delete** /api/v2/outbound/contactlists | Delete multiple contact lists. |
| [**DeleteOutboundContactlisttemplate**](OutboundApi.html#deleteoutboundcontactlisttemplate) | **Delete** /api/v2/outbound/contactlisttemplates/{contactListTemplateId} | Delete Contact List Template |
| [**DeleteOutboundContactlisttemplates**](OutboundApi.html#deleteoutboundcontactlisttemplates) | **Delete** /api/v2/outbound/contactlisttemplates | Delete multiple contact list templates. |
| [**DeleteOutboundDigitalruleset**](OutboundApi.html#deleteoutbounddigitalruleset) | **Delete** /api/v2/outbound/digitalrulesets/{digitalRuleSetId} | Delete an Outbound Digital Rule Set |
| [**DeleteOutboundDnclist**](OutboundApi.html#deleteoutbounddnclist) | **Delete** /api/v2/outbound/dnclists/{dncListId} | Delete dialer DNC list |
| [**DeleteOutboundDnclistCustomexclusioncolumns**](OutboundApi.html#deleteoutbounddnclistcustomexclusioncolumns) | **Delete** /api/v2/outbound/dnclists/{dncListId}/customexclusioncolumns | Deletes all or expired custom exclusion column entries from a DNC list. |
| [**DeleteOutboundDnclistEmailaddresses**](OutboundApi.html#deleteoutbounddnclistemailaddresses) | **Delete** /api/v2/outbound/dnclists/{dncListId}/emailaddresses | Deletes all or expired email addresses from a DNC list. |
| [**DeleteOutboundDnclistPhonenumbers**](OutboundApi.html#deleteoutbounddnclistphonenumbers) | **Delete** /api/v2/outbound/dnclists/{dncListId}/phonenumbers | Deletes all or expired phone numbers from a DNC list. |
| [**DeleteOutboundFilespecificationtemplate**](OutboundApi.html#deleteoutboundfilespecificationtemplate) | **Delete** /api/v2/outbound/filespecificationtemplates/{fileSpecificationTemplateId} | Delete File Specification Template |
| [**DeleteOutboundFilespecificationtemplatesBulk**](OutboundApi.html#deleteoutboundfilespecificationtemplatesbulk) | **Delete** /api/v2/outbound/filespecificationtemplates/bulk | Delete multiple file specification templates. |
| [**DeleteOutboundImporttemplate**](OutboundApi.html#deleteoutboundimporttemplate) | **Delete** /api/v2/outbound/importtemplates/{importTemplateId} | Delete Import Template |
| [**DeleteOutboundImporttemplates**](OutboundApi.html#deleteoutboundimporttemplates) | **Delete** /api/v2/outbound/importtemplates | Delete multiple import templates. |
| [**DeleteOutboundMessagingcampaign**](OutboundApi.html#deleteoutboundmessagingcampaign) | **Delete** /api/v2/outbound/messagingcampaigns/{messagingCampaignId} | Delete an Outbound Messaging Campaign |
| [**DeleteOutboundMessagingcampaignProgress**](OutboundApi.html#deleteoutboundmessagingcampaignprogress) | **Delete** /api/v2/outbound/messagingcampaigns/{messagingCampaignId}/progress | Reset messaging campaign progress and recycle the messaging campaign |
| [**DeleteOutboundRuleset**](OutboundApi.html#deleteoutboundruleset) | **Delete** /api/v2/outbound/rulesets/{ruleSetId} | Delete a Rule Set. |
| [**DeleteOutboundSchedulesCampaign**](OutboundApi.html#deleteoutboundschedulescampaign) | **Delete** /api/v2/outbound/schedules/campaigns/{campaignId} | Delete a dialer campaign schedule. |
| [**DeleteOutboundSchedulesEmailcampaign**](OutboundApi.html#deleteoutboundschedulesemailcampaign) | **Delete** /api/v2/outbound/schedules/emailcampaigns/{emailCampaignId} | Delete an email campaign schedule. |
| [**DeleteOutboundSchedulesMessagingcampaign**](OutboundApi.html#deleteoutboundschedulesmessagingcampaign) | **Delete** /api/v2/outbound/schedules/messagingcampaigns/{messagingCampaignId} | Delete a messaging campaign schedule. |
| [**DeleteOutboundSchedulesSequence**](OutboundApi.html#deleteoutboundschedulessequence) | **Delete** /api/v2/outbound/schedules/sequences/{sequenceId} | Delete a dialer sequence schedule. |
| [**DeleteOutboundSequence**](OutboundApi.html#deleteoutboundsequence) | **Delete** /api/v2/outbound/sequences/{sequenceId} | Delete a dialer campaign sequence. |
| [**GetOutboundAttemptlimit**](OutboundApi.html#getoutboundattemptlimit) | **Get** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Get attempt limits |
| [**GetOutboundAttemptlimits**](OutboundApi.html#getoutboundattemptlimits) | **Get** /api/v2/outbound/attemptlimits | Query attempt limits list |
| [**GetOutboundCallabletimeset**](OutboundApi.html#getoutboundcallabletimeset) | **Get** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Get callable time set |
| [**GetOutboundCallabletimesets**](OutboundApi.html#getoutboundcallabletimesets) | **Get** /api/v2/outbound/callabletimesets | Query callable time set list |
| [**GetOutboundCallanalysisresponseset**](OutboundApi.html#getoutboundcallanalysisresponseset) | **Get** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Get a dialer call analysis response set. |
| [**GetOutboundCallanalysisresponsesets**](OutboundApi.html#getoutboundcallanalysisresponsesets) | **Get** /api/v2/outbound/callanalysisresponsesets | Query a list of dialer call analysis response sets. |
| [**GetOutboundCampaign**](OutboundApi.html#getoutboundcampaign) | **Get** /api/v2/outbound/campaigns/{campaignId} | Get dialer campaign. |
| [**GetOutboundCampaignAgentownedmappingpreviewResults**](OutboundApi.html#getoutboundcampaignagentownedmappingpreviewresults) | **Get** /api/v2/outbound/campaigns/{campaignId}/agentownedmappingpreview/results | Get a preview of how agents will be mapped to this campaign&#39;s contact list. |
| [**GetOutboundCampaignDiagnostics**](OutboundApi.html#getoutboundcampaigndiagnostics) | **Get** /api/v2/outbound/campaigns/{campaignId}/diagnostics | Get campaign diagnostics |
| [**GetOutboundCampaignInteractions**](OutboundApi.html#getoutboundcampaigninteractions) | **Get** /api/v2/outbound/campaigns/{campaignId}/interactions | Get dialer campaign interactions. |
| [**GetOutboundCampaignLinedistribution**](OutboundApi.html#getoutboundcampaignlinedistribution) | **Get** /api/v2/outbound/campaigns/{campaignId}/linedistribution | Get line distribution information for campaigns using same Edge Group or Site as given campaign |
| [**GetOutboundCampaignProgress**](OutboundApi.html#getoutboundcampaignprogress) | **Get** /api/v2/outbound/campaigns/{campaignId}/progress | Get campaign progress |
| [**GetOutboundCampaignStats**](OutboundApi.html#getoutboundcampaignstats) | **Get** /api/v2/outbound/campaigns/{campaignId}/stats | Get statistics about a Dialer Campaign |
| [**GetOutboundCampaignrule**](OutboundApi.html#getoutboundcampaignrule) | **Get** /api/v2/outbound/campaignrules/{campaignRuleId} | Get Campaign Rule |
| [**GetOutboundCampaignrules**](OutboundApi.html#getoutboundcampaignrules) | **Get** /api/v2/outbound/campaignrules | Query Campaign Rule list |
| [**GetOutboundCampaigns**](OutboundApi.html#getoutboundcampaigns) | **Get** /api/v2/outbound/campaigns | Query a list of dialer campaigns. |
| [**GetOutboundCampaignsAll**](OutboundApi.html#getoutboundcampaignsall) | **Get** /api/v2/outbound/campaigns/all | Query across all types of campaigns by division |
| [**GetOutboundCampaignsAllDivisionviews**](OutboundApi.html#getoutboundcampaignsalldivisionviews) | **Get** /api/v2/outbound/campaigns/all/divisionviews | Query across all types of campaigns |
| [**GetOutboundCampaignsDivisionview**](OutboundApi.html#getoutboundcampaignsdivisionview) | **Get** /api/v2/outbound/campaigns/divisionviews/{campaignId} | Get a basic Campaign information object |
| [**GetOutboundCampaignsDivisionviews**](OutboundApi.html#getoutboundcampaignsdivisionviews) | **Get** /api/v2/outbound/campaigns/divisionviews | Query a list of basic Campaign information objects |
| [**GetOutboundContactlist**](OutboundApi.html#getoutboundcontactlist) | **Get** /api/v2/outbound/contactlists/{contactListId} | Get a dialer contact list. |
| [**GetOutboundContactlistContact**](OutboundApi.html#getoutboundcontactlistcontact) | **Get** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Get a contact. |
| [**GetOutboundContactlistExport**](OutboundApi.html#getoutboundcontactlistexport) | **Get** /api/v2/outbound/contactlists/{contactListId}/export | Get the URI of a contact list export. |
| [**GetOutboundContactlistImportstatus**](OutboundApi.html#getoutboundcontactlistimportstatus) | **Get** /api/v2/outbound/contactlists/{contactListId}/importstatus | Get dialer contactList import status. |
| [**GetOutboundContactlistTimezonemappingpreview**](OutboundApi.html#getoutboundcontactlisttimezonemappingpreview) | **Get** /api/v2/outbound/contactlists/{contactListId}/timezonemappingpreview | Preview the result of applying Automatic Time Zone Mapping to a contact list |
| [**GetOutboundContactlistfilter**](OutboundApi.html#getoutboundcontactlistfilter) | **Get** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Get Contact list filter |
| [**GetOutboundContactlistfilters**](OutboundApi.html#getoutboundcontactlistfilters) | **Get** /api/v2/outbound/contactlistfilters | Query Contact list filters |
| [**GetOutboundContactlists**](OutboundApi.html#getoutboundcontactlists) | **Get** /api/v2/outbound/contactlists | Query a list of contact lists. |
| [**GetOutboundContactlistsDivisionview**](OutboundApi.html#getoutboundcontactlistsdivisionview) | **Get** /api/v2/outbound/contactlists/divisionviews/{contactListId} | Get a basic ContactList information object |
| [**GetOutboundContactlistsDivisionviews**](OutboundApi.html#getoutboundcontactlistsdivisionviews) | **Get** /api/v2/outbound/contactlists/divisionviews | Query a list of simplified contact list objects. |
| [**GetOutboundContactlisttemplate**](OutboundApi.html#getoutboundcontactlisttemplate) | **Get** /api/v2/outbound/contactlisttemplates/{contactListTemplateId} | Get Contact List Template |
| [**GetOutboundContactlisttemplates**](OutboundApi.html#getoutboundcontactlisttemplates) | **Get** /api/v2/outbound/contactlisttemplates | Query a list of contact list templates |
| [**GetOutboundDigitalruleset**](OutboundApi.html#getoutbounddigitalruleset) | **Get** /api/v2/outbound/digitalrulesets/{digitalRuleSetId} | Get an Outbound Digital Rule Set |
| [**GetOutboundDigitalrulesets**](OutboundApi.html#getoutbounddigitalrulesets) | **Get** /api/v2/outbound/digitalrulesets | Query a list of Outbound Digital Rule Sets |
| [**GetOutboundDnclist**](OutboundApi.html#getoutbounddnclist) | **Get** /api/v2/outbound/dnclists/{dncListId} | Get dialer DNC list |
| [**GetOutboundDnclistExport**](OutboundApi.html#getoutbounddnclistexport) | **Get** /api/v2/outbound/dnclists/{dncListId}/export | Get the URI of a DNC list export. |
| [**GetOutboundDnclistImportstatus**](OutboundApi.html#getoutbounddnclistimportstatus) | **Get** /api/v2/outbound/dnclists/{dncListId}/importstatus | Get dialer dncList import status. |
| [**GetOutboundDnclists**](OutboundApi.html#getoutbounddnclists) | **Get** /api/v2/outbound/dnclists | Query dialer DNC lists |
| [**GetOutboundDnclistsDivisionview**](OutboundApi.html#getoutbounddnclistsdivisionview) | **Get** /api/v2/outbound/dnclists/divisionviews/{dncListId} | Get a basic DncList information object |
| [**GetOutboundDnclistsDivisionviews**](OutboundApi.html#getoutbounddnclistsdivisionviews) | **Get** /api/v2/outbound/dnclists/divisionviews | Query a list of simplified dnc list objects. |
| [**GetOutboundEvent**](OutboundApi.html#getoutboundevent) | **Get** /api/v2/outbound/events/{eventId} | Get Dialer Event |
| [**GetOutboundEvents**](OutboundApi.html#getoutboundevents) | **Get** /api/v2/outbound/events | Query Event Logs |
| [**GetOutboundFilespecificationtemplate**](OutboundApi.html#getoutboundfilespecificationtemplate) | **Get** /api/v2/outbound/filespecificationtemplates/{fileSpecificationTemplateId} | Get File Specification Template |
| [**GetOutboundFilespecificationtemplates**](OutboundApi.html#getoutboundfilespecificationtemplates) | **Get** /api/v2/outbound/filespecificationtemplates | Query File Specification Templates |
| [**GetOutboundImporttemplate**](OutboundApi.html#getoutboundimporttemplate) | **Get** /api/v2/outbound/importtemplates/{importTemplateId} | Get Import Template |
| [**GetOutboundImporttemplateImportstatus**](OutboundApi.html#getoutboundimporttemplateimportstatus) | **Get** /api/v2/outbound/importtemplates/{importTemplateId}/importstatus | Get the import status for an import template. |
| [**GetOutboundImporttemplates**](OutboundApi.html#getoutboundimporttemplates) | **Get** /api/v2/outbound/importtemplates | Query Import Templates |
| [**GetOutboundMessagingcampaign**](OutboundApi.html#getoutboundmessagingcampaign) | **Get** /api/v2/outbound/messagingcampaigns/{messagingCampaignId} | Get an Outbound Messaging Campaign |
| [**GetOutboundMessagingcampaignDiagnostics**](OutboundApi.html#getoutboundmessagingcampaigndiagnostics) | **Get** /api/v2/outbound/messagingcampaigns/{messagingCampaignId}/diagnostics | Get messaging campaign diagnostics |
| [**GetOutboundMessagingcampaignProgress**](OutboundApi.html#getoutboundmessagingcampaignprogress) | **Get** /api/v2/outbound/messagingcampaigns/{messagingCampaignId}/progress | Get messaging campaign&#39;s progress |
| [**GetOutboundMessagingcampaigns**](OutboundApi.html#getoutboundmessagingcampaigns) | **Get** /api/v2/outbound/messagingcampaigns | Query a list of Messaging Campaigns |
| [**GetOutboundMessagingcampaignsDivisionview**](OutboundApi.html#getoutboundmessagingcampaignsdivisionview) | **Get** /api/v2/outbound/messagingcampaigns/divisionviews/{messagingCampaignId} | Get a basic Messaging Campaign information object |
| [**GetOutboundMessagingcampaignsDivisionviews**](OutboundApi.html#getoutboundmessagingcampaignsdivisionviews) | **Get** /api/v2/outbound/messagingcampaigns/divisionviews | Query a list of basic Messaging Campaign information objects |
| [**GetOutboundRuleset**](OutboundApi.html#getoutboundruleset) | **Get** /api/v2/outbound/rulesets/{ruleSetId} | Get a Rule Set by ID. |
| [**GetOutboundRulesets**](OutboundApi.html#getoutboundrulesets) | **Get** /api/v2/outbound/rulesets | Query a list of Rule Sets. |
| [**GetOutboundSchedulesCampaign**](OutboundApi.html#getoutboundschedulescampaign) | **Get** /api/v2/outbound/schedules/campaigns/{campaignId} | Get a dialer campaign schedule. |
| [**GetOutboundSchedulesCampaigns**](OutboundApi.html#getoutboundschedulescampaigns) | **Get** /api/v2/outbound/schedules/campaigns | Query for a list of dialer campaign schedules. |
| [**GetOutboundSchedulesEmailcampaign**](OutboundApi.html#getoutboundschedulesemailcampaign) | **Get** /api/v2/outbound/schedules/emailcampaigns/{emailCampaignId} | Get an email campaign schedule. |
| [**GetOutboundSchedulesEmailcampaigns**](OutboundApi.html#getoutboundschedulesemailcampaigns) | **Get** /api/v2/outbound/schedules/emailcampaigns | Query for a list of email campaign schedules. |
| [**GetOutboundSchedulesMessagingcampaign**](OutboundApi.html#getoutboundschedulesmessagingcampaign) | **Get** /api/v2/outbound/schedules/messagingcampaigns/{messagingCampaignId} | Get a messaging campaign schedule. |
| [**GetOutboundSchedulesMessagingcampaigns**](OutboundApi.html#getoutboundschedulesmessagingcampaigns) | **Get** /api/v2/outbound/schedules/messagingcampaigns | Query for a list of messaging campaign schedules. |
| [**GetOutboundSchedulesSequence**](OutboundApi.html#getoutboundschedulessequence) | **Get** /api/v2/outbound/schedules/sequences/{sequenceId} | Get a dialer sequence schedule. |
| [**GetOutboundSchedulesSequences**](OutboundApi.html#getoutboundschedulessequences) | **Get** /api/v2/outbound/schedules/sequences | Query for a list of dialer sequence schedules. |
| [**GetOutboundSequence**](OutboundApi.html#getoutboundsequence) | **Get** /api/v2/outbound/sequences/{sequenceId} | Get a dialer campaign sequence. |
| [**GetOutboundSequences**](OutboundApi.html#getoutboundsequences) | **Get** /api/v2/outbound/sequences | Query a list of dialer campaign sequences. |
| [**GetOutboundSettings**](OutboundApi.html#getoutboundsettings) | **Get** /api/v2/outbound/settings | Get the outbound settings for this organization |
| [**GetOutboundWrapupcodemappings**](OutboundApi.html#getoutboundwrapupcodemappings) | **Get** /api/v2/outbound/wrapupcodemappings | Get the Dialer wrap up code mapping. |
| [**PatchOutboundDnclistCustomexclusioncolumns**](OutboundApi.html#patchoutbounddnclistcustomexclusioncolumns) | **Patch** /api/v2/outbound/dnclists/{dncListId}/customexclusioncolumns | Add entries to or delete entries from a DNC list. |
| [**PatchOutboundDnclistEmailaddresses**](OutboundApi.html#patchoutbounddnclistemailaddresses) | **Patch** /api/v2/outbound/dnclists/{dncListId}/emailaddresses | Add emails to or Delete emails from a DNC list. |
| [**PatchOutboundDnclistPhonenumbers**](OutboundApi.html#patchoutbounddnclistphonenumbers) | **Patch** /api/v2/outbound/dnclists/{dncListId}/phonenumbers | Add numbers to or delete numbers from a DNC list. |
| [**PatchOutboundSettings**](OutboundApi.html#patchoutboundsettings) | **Patch** /api/v2/outbound/settings | Update the outbound settings for this organization |
| [**PostOutboundAttemptlimits**](OutboundApi.html#postoutboundattemptlimits) | **Post** /api/v2/outbound/attemptlimits | Create attempt limits |
| [**PostOutboundAudits**](OutboundApi.html#postoutboundaudits) | **Post** /api/v2/outbound/audits | Retrieves audits for dialer. (Deprecated) |
| [**PostOutboundCallabletimesets**](OutboundApi.html#postoutboundcallabletimesets) | **Post** /api/v2/outbound/callabletimesets | Create callable time set |
| [**PostOutboundCallanalysisresponsesets**](OutboundApi.html#postoutboundcallanalysisresponsesets) | **Post** /api/v2/outbound/callanalysisresponsesets | Create a dialer call analysis response set. |
| [**PostOutboundCampaignAgentownedmappingpreview**](OutboundApi.html#postoutboundcampaignagentownedmappingpreview) | **Post** /api/v2/outbound/campaigns/{campaignId}/agentownedmappingpreview | Initiate request for a preview of how agents will be mapped to this campaign&#39;s contact list. |
| [**PostOutboundCampaignCallbackSchedule**](OutboundApi.html#postoutboundcampaigncallbackschedule) | **Post** /api/v2/outbound/campaigns/{campaignId}/callback/schedule | Schedule a Callback for a Dialer Campaign (Deprecated) |
| [**PostOutboundCampaignrules**](OutboundApi.html#postoutboundcampaignrules) | **Post** /api/v2/outbound/campaignrules | Create Campaign Rule |
| [**PostOutboundCampaigns**](OutboundApi.html#postoutboundcampaigns) | **Post** /api/v2/outbound/campaigns | Create a campaign. |
| [**PostOutboundCampaignsProgress**](OutboundApi.html#postoutboundcampaignsprogress) | **Post** /api/v2/outbound/campaigns/progress | Get progress for a list of campaigns |
| [**PostOutboundContactlistClear**](OutboundApi.html#postoutboundcontactlistclear) | **Post** /api/v2/outbound/contactlists/{contactListId}/clear | Deletes all contacts out of a list. All outstanding recalls or rule-scheduled callbacks for non-preview campaigns configured with the contactlist will be cancelled. |
| [**PostOutboundContactlistContacts**](OutboundApi.html#postoutboundcontactlistcontacts) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts | Add contacts to a contact list. |
| [**PostOutboundContactlistContactsBulk**](OutboundApi.html#postoutboundcontactlistcontactsbulk) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts/bulk | Get contacts from a contact list. |
| [**PostOutboundContactlistContactsBulkRemove**](OutboundApi.html#postoutboundcontactlistcontactsbulkremove) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts/bulk/remove | Start an async job to delete contacts using a filter. |
| [**PostOutboundContactlistContactsBulkUpdate**](OutboundApi.html#postoutboundcontactlistcontactsbulkupdate) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts/bulk/update | Start an async job to bulk edit contacts. |
| [**PostOutboundContactlistContactsSearch**](OutboundApi.html#postoutboundcontactlistcontactssearch) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts/search | Query contacts from a contact list. |
| [**PostOutboundContactlistExport**](OutboundApi.html#postoutboundcontactlistexport) | **Post** /api/v2/outbound/contactlists/{contactListId}/export | Initiate the export of a contact list. |
| [**PostOutboundContactlistfilters**](OutboundApi.html#postoutboundcontactlistfilters) | **Post** /api/v2/outbound/contactlistfilters | Create Contact List Filter |
| [**PostOutboundContactlistfiltersBulkRetrieve**](OutboundApi.html#postoutboundcontactlistfiltersbulkretrieve) | **Post** /api/v2/outbound/contactlistfilters/bulk/retrieve | Retrieve multiple contact list filters |
| [**PostOutboundContactlistfiltersPreview**](OutboundApi.html#postoutboundcontactlistfilterspreview) | **Post** /api/v2/outbound/contactlistfilters/preview | Get a preview of the output of a contact list filter |
| [**PostOutboundContactlists**](OutboundApi.html#postoutboundcontactlists) | **Post** /api/v2/outbound/contactlists | Create a contact List. |
| [**PostOutboundContactlisttemplates**](OutboundApi.html#postoutboundcontactlisttemplates) | **Post** /api/v2/outbound/contactlisttemplates | Create Contact List Template |
| [**PostOutboundContactlisttemplatesBulkAdd**](OutboundApi.html#postoutboundcontactlisttemplatesbulkadd) | **Post** /api/v2/outbound/contactlisttemplates/bulk/add | Add multiple contact list templates |
| [**PostOutboundContactlisttemplatesBulkRetrieve**](OutboundApi.html#postoutboundcontactlisttemplatesbulkretrieve) | **Post** /api/v2/outbound/contactlisttemplates/bulk/retrieve | Get multiple contact list templates |
| [**PostOutboundConversationDnc**](OutboundApi.html#postoutboundconversationdnc) | **Post** /api/v2/outbound/conversations/{conversationId}/dnc | Add phone numbers to a Dialer DNC list. |
| [**PostOutboundDigitalrulesets**](OutboundApi.html#postoutbounddigitalrulesets) | **Post** /api/v2/outbound/digitalrulesets | Create an Outbound Digital Rule Set |
| [**PostOutboundDnclistEmailaddresses**](OutboundApi.html#postoutbounddnclistemailaddresses) | **Post** /api/v2/outbound/dnclists/{dncListId}/emailaddresses | Add email addresses to a DNC list. |
| [**PostOutboundDnclistExport**](OutboundApi.html#postoutbounddnclistexport) | **Post** /api/v2/outbound/dnclists/{dncListId}/export | Initiate the export of a dnc list. |
| [**PostOutboundDnclistPhonenumbers**](OutboundApi.html#postoutbounddnclistphonenumbers) | **Post** /api/v2/outbound/dnclists/{dncListId}/phonenumbers | Add phone numbers to a DNC list. |
| [**PostOutboundDnclists**](OutboundApi.html#postoutbounddnclists) | **Post** /api/v2/outbound/dnclists | Create dialer DNC list |
| [**PostOutboundFilespecificationtemplates**](OutboundApi.html#postoutboundfilespecificationtemplates) | **Post** /api/v2/outbound/filespecificationtemplates | Create File Specification Template |
| [**PostOutboundImporttemplates**](OutboundApi.html#postoutboundimporttemplates) | **Post** /api/v2/outbound/importtemplates | Create Import Template |
| [**PostOutboundImporttemplatesBulkAdd**](OutboundApi.html#postoutboundimporttemplatesbulkadd) | **Post** /api/v2/outbound/importtemplates/bulk/add | Add multiple import templates |
| [**PostOutboundMessagingcampaigns**](OutboundApi.html#postoutboundmessagingcampaigns) | **Post** /api/v2/outbound/messagingcampaigns | Create a Messaging Campaign |
| [**PostOutboundMessagingcampaignsProgress**](OutboundApi.html#postoutboundmessagingcampaignsprogress) | **Post** /api/v2/outbound/messagingcampaigns/progress | Get progress for a list of messaging campaigns |
| [**PostOutboundRulesets**](OutboundApi.html#postoutboundrulesets) | **Post** /api/v2/outbound/rulesets | Create a Rule Set. |
| [**PostOutboundSequences**](OutboundApi.html#postoutboundsequences) | **Post** /api/v2/outbound/sequences | Create a new campaign sequence. |
| [**PutOutboundAttemptlimit**](OutboundApi.html#putoutboundattemptlimit) | **Put** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Update attempt limits |
| [**PutOutboundCallabletimeset**](OutboundApi.html#putoutboundcallabletimeset) | **Put** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Update callable time set |
| [**PutOutboundCallanalysisresponseset**](OutboundApi.html#putoutboundcallanalysisresponseset) | **Put** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Update a dialer call analysis response set. |
| [**PutOutboundCampaign**](OutboundApi.html#putoutboundcampaign) | **Put** /api/v2/outbound/campaigns/{campaignId} | Update a campaign. |
| [**PutOutboundCampaignAgent**](OutboundApi.html#putoutboundcampaignagent) | **Put** /api/v2/outbound/campaigns/{campaignId}/agents/{userId} | Send notification that an agent&#39;s state changed  |
| [**PutOutboundCampaignrule**](OutboundApi.html#putoutboundcampaignrule) | **Put** /api/v2/outbound/campaignrules/{campaignRuleId} | Update Campaign Rule |
| [**PutOutboundContactlist**](OutboundApi.html#putoutboundcontactlist) | **Put** /api/v2/outbound/contactlists/{contactListId} | Update a contact list. |
| [**PutOutboundContactlistContact**](OutboundApi.html#putoutboundcontactlistcontact) | **Put** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Update a contact. |
| [**PutOutboundContactlistfilter**](OutboundApi.html#putoutboundcontactlistfilter) | **Put** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Update Contact List Filter |
| [**PutOutboundContactlisttemplate**](OutboundApi.html#putoutboundcontactlisttemplate) | **Put** /api/v2/outbound/contactlisttemplates/{contactListTemplateId} | Update a contact list template. |
| [**PutOutboundDigitalruleset**](OutboundApi.html#putoutbounddigitalruleset) | **Put** /api/v2/outbound/digitalrulesets/{digitalRuleSetId} | Update an Outbound Digital Rule Set |
| [**PutOutboundDnclist**](OutboundApi.html#putoutbounddnclist) | **Put** /api/v2/outbound/dnclists/{dncListId} | Update dialer DNC list |
| [**PutOutboundFilespecificationtemplate**](OutboundApi.html#putoutboundfilespecificationtemplate) | **Put** /api/v2/outbound/filespecificationtemplates/{fileSpecificationTemplateId} | Update File Specification Template |
| [**PutOutboundImporttemplate**](OutboundApi.html#putoutboundimporttemplate) | **Put** /api/v2/outbound/importtemplates/{importTemplateId} | Update Import Template |
| [**PutOutboundMessagingcampaign**](OutboundApi.html#putoutboundmessagingcampaign) | **Put** /api/v2/outbound/messagingcampaigns/{messagingCampaignId} | Update an Outbound Messaging Campaign |
| [**PutOutboundRuleset**](OutboundApi.html#putoutboundruleset) | **Put** /api/v2/outbound/rulesets/{ruleSetId} | Update a Rule Set. |
| [**PutOutboundSchedulesCampaign**](OutboundApi.html#putoutboundschedulescampaign) | **Put** /api/v2/outbound/schedules/campaigns/{campaignId} | Update a new campaign schedule. |
| [**PutOutboundSchedulesEmailcampaign**](OutboundApi.html#putoutboundschedulesemailcampaign) | **Put** /api/v2/outbound/schedules/emailcampaigns/{emailCampaignId} | Update an email campaign schedule. |
| [**PutOutboundSchedulesMessagingcampaign**](OutboundApi.html#putoutboundschedulesmessagingcampaign) | **Put** /api/v2/outbound/schedules/messagingcampaigns/{messagingCampaignId} | Update a new messaging campaign schedule. |
| [**PutOutboundSchedulesSequence**](OutboundApi.html#putoutboundschedulessequence) | **Put** /api/v2/outbound/schedules/sequences/{sequenceId} | Update a new sequence schedule. |
| [**PutOutboundSequence**](OutboundApi.html#putoutboundsequence) | **Put** /api/v2/outbound/sequences/{sequenceId} | Update a new campaign sequence. |
| [**PutOutboundWrapupcodemappings**](OutboundApi.html#putoutboundwrapupcodemappings) | **Put** /api/v2/outbound/wrapupcodemappings | Update the Dialer wrap up code mapping. |
{: class="table table-striped"}

<a name="deleteoutboundattemptlimit"></a>

## void DeleteOutboundAttemptlimit (string attemptLimitsId)



Delete attempt limits

Requires ANY permissions: 

* outbound:attemptLimits:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundAttemptlimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID

            try
            { 
                // Delete attempt limits
                apiInstance.DeleteOutboundAttemptlimit(attemptLimitsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcallabletimeset"></a>

## void DeleteOutboundCallabletimeset (string callableTimeSetId)



Delete callable time set

Requires ANY permissions: 

* outbound:callableTimeSet:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCallabletimesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID

            try
            { 
                // Delete callable time set
                apiInstance.DeleteOutboundCallabletimeset(callableTimeSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcallanalysisresponseset"></a>

## void DeleteOutboundCallanalysisresponseset (string callAnalysisSetId)



Delete a dialer call analysis response set.

Requires ANY permissions: 

* outbound:responseSet:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCallanalysisresponsesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID

            try
            { 
                // Delete a dialer call analysis response set.
                apiInstance.DeleteOutboundCallanalysisresponseset(callAnalysisSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcampaign"></a>

## [**Campaign**](Campaign.html) DeleteOutboundCampaign (string campaignId)



Delete a campaign.

Requires ANY permissions: 

* outbound:campaign:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Delete a campaign.
                Campaign result = apiInstance.DeleteOutboundCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="deleteoutboundcampaignprogress"></a>

## void DeleteOutboundCampaignProgress (string campaignId)



Reset campaign progress and recycle the campaign

Requires ANY permissions: 

* outbound:campaign:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Reset campaign progress and recycle the campaign
                apiInstance.DeleteOutboundCampaignProgress(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaignProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcampaignrule"></a>

## void DeleteOutboundCampaignrule (string campaignRuleId)



Delete Campaign Rule

Requires ANY permissions: 

* outbound:campaignRule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID

            try
            { 
                // Delete Campaign Rule
                apiInstance.DeleteOutboundCampaignrule(campaignRuleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlist"></a>

## void DeleteOutboundContactlist (string contactListId)



Delete a contact list.

Requires ANY permissions: 

* outbound:contactList:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            { 
                // Delete a contact list.
                apiInstance.DeleteOutboundContactlist(contactListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlistcontact"></a>

## void DeleteOutboundContactlistContact (string contactListId, string contactId)



Delete a contact.

Requires ANY permissions: 

* outbound:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID

            try
            { 
                // Delete a contact.
                apiInstance.DeleteOutboundContactlistContact(contactListId, contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlistcontacts"></a>

## void DeleteOutboundContactlistContacts (string contactListId, List<string> contactIds)



Delete contacts from a contact list.

Requires ANY permissions: 

* outbound:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactIds = new List<string>(); // List<string> | ContactIds to delete.

            try
            { 
                // Delete contacts from a contact list.
                apiInstance.DeleteOutboundContactlistContacts(contactListId, contactIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactIds** | [**List<string>**](string.html)| ContactIds to delete. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlistfilter"></a>

## void DeleteOutboundContactlistfilter (string contactListFilterId)



Delete Contact List Filter

Requires ANY permissions: 

* outbound:contactListFilter:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistfilterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID

            try
            { 
                // Delete Contact List Filter
                apiInstance.DeleteOutboundContactlistfilter(contactListFilterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlists"></a>

## void DeleteOutboundContactlists (List<string> id)



Delete multiple contact lists.

Requires ANY permissions: 

* outbound:contactList:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var id = new List<string>(); // List<string> | contact list id(s) to delete

            try
            { 
                // Delete multiple contact lists.
                apiInstance.DeleteOutboundContactlists(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| contact list id(s) to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlisttemplate"></a>

## void DeleteOutboundContactlisttemplate (string contactListTemplateId)



Delete Contact List Template

Requires ANY permissions: 

* outbound:contactListTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlisttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListTemplateId = contactListTemplateId_example;  // string | ContactListTemplate ID

            try
            { 
                // Delete Contact List Template
                apiInstance.DeleteOutboundContactlisttemplate(contactListTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlisttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListTemplateId** | **string**| ContactListTemplate ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlisttemplates"></a>

## void DeleteOutboundContactlisttemplates (List<string> id)



Delete multiple contact list templates.

Requires ANY permissions: 

* outbound:contactListTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlisttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var id = new List<string>(); // List<string> | contact list template id(s) to delete

            try
            { 
                // Delete multiple contact list templates.
                apiInstance.DeleteOutboundContactlisttemplates(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlisttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| contact list template id(s) to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutbounddigitalruleset"></a>

## void DeleteOutboundDigitalruleset (string digitalRuleSetId)



Delete an Outbound Digital Rule Set

Requires ANY permissions: 

* outbound:digitalRuleSet:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDigitalrulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var digitalRuleSetId = digitalRuleSetId_example;  // string | The Digital Rule Set ID

            try
            { 
                // Delete an Outbound Digital Rule Set
                apiInstance.DeleteOutboundDigitalruleset(digitalRuleSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDigitalruleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **digitalRuleSetId** | **string**| The Digital Rule Set ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutbounddnclist"></a>

## void DeleteOutboundDnclist (string dncListId)



Delete dialer DNC list

Requires ANY permissions: 

* outbound:dncList:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            { 
                // Delete dialer DNC list
                apiInstance.DeleteOutboundDnclist(dncListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutbounddnclistcustomexclusioncolumns"></a>

## void DeleteOutboundDnclistCustomexclusioncolumns (string dncListId, bool? expiredOnly = null)



Deletes all or expired custom exclusion column entries from a DNC list.

This operation is only for Internal DNC lists of custom exclusion column entries

Requires ANY permissions: 

* outbound:dnc:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistCustomexclusioncolumnsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var expiredOnly = true;  // bool? | Set to true to only remove DNC entries that are expired (optional)  (default to false)

            try
            { 
                // Deletes all or expired custom exclusion column entries from a DNC list.
                apiInstance.DeleteOutboundDnclistCustomexclusioncolumns(dncListId, expiredOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclistCustomexclusioncolumns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **expiredOnly** | **bool?**| Set to true to only remove DNC entries that are expired | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutbounddnclistemailaddresses"></a>

## void DeleteOutboundDnclistEmailaddresses (string dncListId, bool? expiredOnly = null)



Deletes all or expired email addresses from a DNC list.

This operation is Only for Internal DNC lists of email addresses

Requires ANY permissions: 

* outbound:dnc:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistEmailaddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var expiredOnly = true;  // bool? | Set to true to only remove DNC entries that are expired (optional)  (default to false)

            try
            { 
                // Deletes all or expired email addresses from a DNC list.
                apiInstance.DeleteOutboundDnclistEmailaddresses(dncListId, expiredOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclistEmailaddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **expiredOnly** | **bool?**| Set to true to only remove DNC entries that are expired | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutbounddnclistphonenumbers"></a>

## void DeleteOutboundDnclistPhonenumbers (string dncListId, bool? expiredOnly = null)



Deletes all or expired phone numbers from a DNC list.

This operation is Only for Internal DNC lists of phone numbers

Requires ANY permissions: 

* outbound:dnc:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistPhonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var expiredOnly = true;  // bool? | Set to true to only remove DNC entries that are expired (optional)  (default to false)

            try
            { 
                // Deletes all or expired phone numbers from a DNC list.
                apiInstance.DeleteOutboundDnclistPhonenumbers(dncListId, expiredOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclistPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **expiredOnly** | **bool?**| Set to true to only remove DNC entries that are expired | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundfilespecificationtemplate"></a>

## void DeleteOutboundFilespecificationtemplate (string fileSpecificationTemplateId)



Delete File Specification Template

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundFilespecificationtemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var fileSpecificationTemplateId = fileSpecificationTemplateId_example;  // string | File Specification Template ID

            try
            { 
                // Delete File Specification Template
                apiInstance.DeleteOutboundFilespecificationtemplate(fileSpecificationTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundFilespecificationtemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **fileSpecificationTemplateId** | **string**| File Specification Template ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundfilespecificationtemplatesbulk"></a>

## void DeleteOutboundFilespecificationtemplatesBulk (List<string> id)



Delete multiple file specification templates.

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundFilespecificationtemplatesBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var id = new List<string>(); // List<string> | File Specification template id(s) to delete

            try
            { 
                // Delete multiple file specification templates.
                apiInstance.DeleteOutboundFilespecificationtemplatesBulk(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundFilespecificationtemplatesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| File Specification template id(s) to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundimporttemplate"></a>

## void DeleteOutboundImporttemplate (string importTemplateId)



Delete Import Template

Requires ANY permissions: 

* outbound:importTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundImporttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var importTemplateId = importTemplateId_example;  // string | Import Template ID

            try
            { 
                // Delete Import Template
                apiInstance.DeleteOutboundImporttemplate(importTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundImporttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importTemplateId** | **string**| Import Template ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundimporttemplates"></a>

## void DeleteOutboundImporttemplates (List<string> id)



Delete multiple import templates.

Requires ANY permissions: 

* outbound:importTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundImporttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var id = new List<string>(); // List<string> | import template id(s) to delete

            try
            { 
                // Delete multiple import templates.
                apiInstance.DeleteOutboundImporttemplates(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundImporttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| import template id(s) to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundmessagingcampaign"></a>

## [**MessagingCampaign**](MessagingCampaign.html) DeleteOutboundMessagingcampaign (string messagingCampaignId)



Delete an Outbound Messaging Campaign

Requires ANY permissions: 

* outbound:messagingCampaign:delete
* outbound:emailCampaign:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Delete an Outbound Messaging Campaign
                MessagingCampaign result = apiInstance.DeleteOutboundMessagingcampaign(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |
{: class="table table-striped"}

### Return type

[**MessagingCampaign**](MessagingCampaign.html)

<a name="deleteoutboundmessagingcampaignprogress"></a>

## void DeleteOutboundMessagingcampaignProgress (string messagingCampaignId)



Reset messaging campaign progress and recycle the messaging campaign

Requires ANY permissions: 

* outbound:messagingCampaign:edit
* outbound:emailCampaign:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundMessagingcampaignProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Reset messaging campaign progress and recycle the messaging campaign
                apiInstance.DeleteOutboundMessagingcampaignProgress(messagingCampaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundMessagingcampaignProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundruleset"></a>

## void DeleteOutboundRuleset (string ruleSetId)



Delete a Rule Set.

Requires ANY permissions: 

* outbound:ruleSet:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundRulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID

            try
            { 
                // Delete a Rule Set.
                apiInstance.DeleteOutboundRuleset(ruleSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundRuleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundschedulescampaign"></a>

## void DeleteOutboundSchedulesCampaign (string campaignId)



Delete a dialer campaign schedule.

Requires ANY permissions: 

* outbound:schedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Delete a dialer campaign schedule.
                apiInstance.DeleteOutboundSchedulesCampaign(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundschedulesemailcampaign"></a>

## void DeleteOutboundSchedulesEmailcampaign (string emailCampaignId)



Delete an email campaign schedule.

Requires ANY permissions: 

* outbound:emailCampaignSchedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesEmailcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var emailCampaignId = emailCampaignId_example;  // string | Email Campaign ID

            try
            { 
                // Delete an email campaign schedule.
                apiInstance.DeleteOutboundSchedulesEmailcampaign(emailCampaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesEmailcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailCampaignId** | **string**| Email Campaign ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundschedulesmessagingcampaign"></a>

## void DeleteOutboundSchedulesMessagingcampaign (string messagingCampaignId)



Delete a messaging campaign schedule.

Requires ANY permissions: 

* outbound:messagingCampaignSchedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | Messaging Campaign ID

            try
            { 
                // Delete a messaging campaign schedule.
                apiInstance.DeleteOutboundSchedulesMessagingcampaign(messagingCampaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| Messaging Campaign ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundschedulessequence"></a>

## void DeleteOutboundSchedulesSequence (string sequenceId)



Delete a dialer sequence schedule.

Requires ANY permissions: 

* outbound:schedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID

            try
            { 
                // Delete a dialer sequence schedule.
                apiInstance.DeleteOutboundSchedulesSequence(sequenceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundsequence"></a>

## void DeleteOutboundSequence (string sequenceId)



Delete a dialer campaign sequence.

Requires ANY permissions: 

* outbound:campaignSequence:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID

            try
            { 
                // Delete a dialer campaign sequence.
                apiInstance.DeleteOutboundSequence(sequenceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getoutboundattemptlimit"></a>

## [**AttemptLimits**](AttemptLimits.html) GetOutboundAttemptlimit (string attemptLimitsId)



Get attempt limits

Requires ANY permissions: 

* outbound:attemptLimits:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundAttemptlimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID

            try
            { 
                // Get attempt limits
                AttemptLimits result = apiInstance.GetOutboundAttemptlimit(attemptLimitsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |
{: class="table table-striped"}

### Return type

[**AttemptLimits**](AttemptLimits.html)

<a name="getoutboundattemptlimits"></a>

## [**AttemptLimitsEntityListing**](AttemptLimitsEntityListing.html) GetOutboundAttemptlimits (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)



Query attempt limits list

Requires ANY permissions: 

* outbound:attemptLimits:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundAttemptlimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query attempt limits list
                AttemptLimitsEntityListing result = apiInstance.GetOutboundAttemptlimits(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundAttemptlimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**AttemptLimitsEntityListing**](AttemptLimitsEntityListing.html)

<a name="getoutboundcallabletimeset"></a>

## [**CallableTimeSet**](CallableTimeSet.html) GetOutboundCallabletimeset (string callableTimeSetId)



Get callable time set

Requires ANY permissions: 

* outbound:callableTimeSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallabletimesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID

            try
            { 
                // Get callable time set
                CallableTimeSet result = apiInstance.GetOutboundCallabletimeset(callableTimeSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="getoutboundcallabletimesets"></a>

## [**CallableTimeSetEntityListing**](CallableTimeSetEntityListing.html) GetOutboundCallabletimesets (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)



Query callable time set list

Requires ANY permissions: 

* outbound:callableTimeSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallabletimesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query callable time set list
                CallableTimeSetEntityListing result = apiInstance.GetOutboundCallabletimesets(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallabletimesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CallableTimeSetEntityListing**](CallableTimeSetEntityListing.html)

<a name="getoutboundcallanalysisresponseset"></a>

## [**ResponseSet**](ResponseSet.html) GetOutboundCallanalysisresponseset (string callAnalysisSetId)



Get a dialer call analysis response set.

Requires ANY permissions: 

* outbound:responseSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallanalysisresponsesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID

            try
            { 
                // Get a dialer call analysis response set.
                ResponseSet result = apiInstance.GetOutboundCallanalysisresponseset(callAnalysisSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="getoutboundcallanalysisresponsesets"></a>

## [**ResponseSetEntityListing**](ResponseSetEntityListing.html) GetOutboundCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)



Query a list of dialer call analysis response sets.

Requires ANY permissions: 

* outbound:responseSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallanalysisresponsesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of dialer call analysis response sets.
                ResponseSetEntityListing result = apiInstance.GetOutboundCallanalysisresponsesets(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallanalysisresponsesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**ResponseSetEntityListing**](ResponseSetEntityListing.html)

<a name="getoutboundcampaign"></a>

## [**Campaign**](Campaign.html) GetOutboundCampaign (string campaignId)



Get dialer campaign.

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get dialer campaign.
                Campaign result = apiInstance.GetOutboundCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="getoutboundcampaignagentownedmappingpreviewresults"></a>

## [**AgentOwnedMappingPreviewListing**](AgentOwnedMappingPreviewListing.html) GetOutboundCampaignAgentownedmappingpreviewResults (string campaignId)



Get a preview of how agents will be mapped to this campaign's contact list.

Requires ALL permissions: 

* outbound:campaign:view
* outbound:contact:view
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignAgentownedmappingpreviewResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get a preview of how agents will be mapped to this campaign's contact list.
                AgentOwnedMappingPreviewListing result = apiInstance.GetOutboundCampaignAgentownedmappingpreviewResults(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignAgentownedmappingpreviewResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**AgentOwnedMappingPreviewListing**](AgentOwnedMappingPreviewListing.html)

<a name="getoutboundcampaigndiagnostics"></a>

## [**CampaignDiagnostics**](CampaignDiagnostics.html) GetOutboundCampaignDiagnostics (string campaignId)



Get campaign diagnostics

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignDiagnosticsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get campaign diagnostics
                CampaignDiagnostics result = apiInstance.GetOutboundCampaignDiagnostics(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignDiagnostics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignDiagnostics**](CampaignDiagnostics.html)

<a name="getoutboundcampaigninteractions"></a>

## [**CampaignInteractions**](CampaignInteractions.html) GetOutboundCampaignInteractions (string campaignId)



Get dialer campaign interactions.

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignInteractionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get dialer campaign interactions.
                CampaignInteractions result = apiInstance.GetOutboundCampaignInteractions(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignInteractions**](CampaignInteractions.html)

<a name="getoutboundcampaignlinedistribution"></a>

## [**CampaignOutboundLinesDistribution**](CampaignOutboundLinesDistribution.html) GetOutboundCampaignLinedistribution (string campaignId, bool? includeOnlyActiveCampaigns = null, string edgeGroupId = null, string siteId = null, bool? useWeight = null, int? relativeWeight = null, int? outboundLineCount = null)



Get line distribution information for campaigns using same Edge Group or Site as given campaign

Requires ANY permissions: 

* outbound:lineDistribution:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignLinedistributionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var includeOnlyActiveCampaigns = true;  // bool? | If true will return only active Campaigns (optional)  (default to true)
            var edgeGroupId = edgeGroupId_example;  // string | Edge group to be used in line distribution calculations instead of current Campaign's Edge Group. Campaign's Site and Edge Group are mutually exclusive. (optional) 
            var siteId = siteId_example;  // string | Site to be used in line distribution calculations instead of current Campaign's Site.  Campaign's Site and Edge Group are mutually exclusive. (optional) 
            var useWeight = true;  // bool? | Enable usage of weight, this value overrides current Campaign's setting in line distribution calculations (optional) 
            var relativeWeight = 56;  // int? | Relative weight to be used in line distribution calculations instead of current Campaign's relative weight (optional) 
            var outboundLineCount = 56;  // int? | The number of outbound lines to be used in line distribution calculations, instead of current Campaign's Outbound Lines Count (optional) 

            try
            { 
                // Get line distribution information for campaigns using same Edge Group or Site as given campaign
                CampaignOutboundLinesDistribution result = apiInstance.GetOutboundCampaignLinedistribution(campaignId, includeOnlyActiveCampaigns, edgeGroupId, siteId, useWeight, relativeWeight, outboundLineCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignLinedistribution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **includeOnlyActiveCampaigns** | **bool?**| If true will return only active Campaigns | [optional] [default to true] |
| **edgeGroupId** | **string**| Edge group to be used in line distribution calculations instead of current Campaign&#39;s Edge Group. Campaign&#39;s Site and Edge Group are mutually exclusive. | [optional]  |
| **siteId** | **string**| Site to be used in line distribution calculations instead of current Campaign&#39;s Site.  Campaign&#39;s Site and Edge Group are mutually exclusive. | [optional]  |
| **useWeight** | **bool?**| Enable usage of weight, this value overrides current Campaign&#39;s setting in line distribution calculations | [optional]  |
| **relativeWeight** | **int?**| Relative weight to be used in line distribution calculations instead of current Campaign&#39;s relative weight | [optional]  |
| **outboundLineCount** | **int?**| The number of outbound lines to be used in line distribution calculations, instead of current Campaign&#39;s Outbound Lines Count | [optional]  |
{: class="table table-striped"}

### Return type

[**CampaignOutboundLinesDistribution**](CampaignOutboundLinesDistribution.html)

<a name="getoutboundcampaignprogress"></a>

## [**CampaignProgress**](CampaignProgress.html) GetOutboundCampaignProgress (string campaignId)



Get campaign progress

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get campaign progress
                CampaignProgress result = apiInstance.GetOutboundCampaignProgress(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignProgress**](CampaignProgress.html)

<a name="getoutboundcampaignstats"></a>

## [**CampaignStats**](CampaignStats.html) GetOutboundCampaignStats (string campaignId)



Get statistics about a Dialer Campaign

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignStatsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get statistics about a Dialer Campaign
                CampaignStats result = apiInstance.GetOutboundCampaignStats(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignStats: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignStats**](CampaignStats.html)

<a name="getoutboundcampaignrule"></a>

## [**CampaignRule**](CampaignRule.html) GetOutboundCampaignrule (string campaignRuleId)



Get Campaign Rule

Requires ANY permissions: 

* outbound:campaignRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID

            try
            { 
                // Get Campaign Rule
                CampaignRule result = apiInstance.GetOutboundCampaignrule(campaignRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |
{: class="table table-striped"}

### Return type

[**CampaignRule**](CampaignRule.html)

<a name="getoutboundcampaignrules"></a>

## [**CampaignRuleEntityListing**](CampaignRuleEntityListing.html) GetOutboundCampaignrules (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)



Query Campaign Rule list

Requires ANY permissions: 

* outbound:campaignRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignrulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query Campaign Rule list
                CampaignRuleEntityListing result = apiInstance.GetOutboundCampaignrules(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignrules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CampaignRuleEntityListing**](CampaignRuleEntityListing.html)

<a name="getoutboundcampaigns"></a>

## [**CampaignEntityListing**](CampaignEntityListing.html) GetOutboundCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, List<string> id = null, string contactListId = null, string dncListIds = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null)



Query a list of dialer campaigns.

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 
            var dncListIds = dncListIds_example;  // string | DNC list ID (optional) 
            var distributionQueueId = distributionQueueId_example;  // string | Distribution queue ID (optional) 
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID (optional) 
            var callAnalysisResponseSetId = callAnalysisResponseSetId_example;  // string | Call analysis response set ID (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of dialer campaigns.
                CampaignEntityListing result = apiInstance.GetOutboundCampaigns(pageSize, pageNumber, filterType, name, id, contactListId, dncListIds, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, divisionId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **contactListId** | **string**| Contact List ID | [optional]  |
| **dncListIds** | **string**| DNC list ID | [optional]  |
| **distributionQueueId** | **string**| Distribution queue ID | [optional]  |
| **edgeGroupId** | **string**| Edge group ID | [optional]  |
| **callAnalysisResponseSetId** | **string**| Call analysis response set ID | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CampaignEntityListing**](CampaignEntityListing.html)

<a name="getoutboundcampaignsall"></a>

## [**CommonCampaignEntityListing**](CommonCampaignEntityListing.html) GetOutboundCampaignsAll (int? pageSize = null, int? pageNumber = null, List<string> id = null, string name = null, List<string> divisionId = null, List<string> mediaType = null, string sortOrder = null)



Query across all types of campaigns by division

Requires ANY permissions: 

* outbound:campaign:view
* outbound:messagingCampaign:view
* outbound:emailCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | Campaign ID(s) (optional) 
            var name = name_example;  // string | Campaign name(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var mediaType = new List<string>(); // List<string> | Media type(s) (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query across all types of campaigns by division
                CommonCampaignEntityListing result = apiInstance.GetOutboundCampaignsAll(pageSize, pageNumber, id, name, divisionId, mediaType, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignsAll: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **id** | [**List<string>**](string.html)| Campaign ID(s) | [optional]  |
| **name** | **string**| Campaign name(s) | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
| **mediaType** | [**List<string>**](string.html)| Media type(s) | [optional] <br />**Values**: email, sms, voice |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CommonCampaignEntityListing**](CommonCampaignEntityListing.html)

<a name="getoutboundcampaignsalldivisionviews"></a>

## [**CommonCampaignDivisionViewEntityListing**](CommonCampaignDivisionViewEntityListing.html) GetOutboundCampaignsAllDivisionviews (int? pageSize = null, int? pageNumber = null, List<string> id = null, string name = null, List<string> divisionId = null, List<string> mediaType = null, string sortOrder = null)



Query across all types of campaigns

Requires ANY permissions: 

* outbound:campaign:search
* outbound:messagingCampaign:search
* outbound:emailCampaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsAllDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | Campaign ID(s) (optional) 
            var name = name_example;  // string | Campaign name(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var mediaType = new List<string>(); // List<string> | Media type(s) (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query across all types of campaigns
                CommonCampaignDivisionViewEntityListing result = apiInstance.GetOutboundCampaignsAllDivisionviews(pageSize, pageNumber, id, name, divisionId, mediaType, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignsAllDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **id** | [**List<string>**](string.html)| Campaign ID(s) | [optional]  |
| **name** | **string**| Campaign name(s) | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
| **mediaType** | [**List<string>**](string.html)| Media type(s) | [optional] <br />**Values**: email, sms, voice |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CommonCampaignDivisionViewEntityListing**](CommonCampaignDivisionViewEntityListing.html)

<a name="getoutboundcampaignsdivisionview"></a>

## [**CampaignDivisionView**](CampaignDivisionView.html) GetOutboundCampaignsDivisionview (string campaignId)



Get a basic Campaign information object

This returns a simplified version of a Campaign, consisting of name and division.

Requires ALL permissions: 

* outbound:campaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get a basic Campaign information object
                CampaignDivisionView result = apiInstance.GetOutboundCampaignsDivisionview(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignsDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignDivisionView**](CampaignDivisionView.html)

<a name="getoutboundcampaignsdivisionviews"></a>

## [**CampaignDivisionViewListing**](CampaignDivisionViewListing.html) GetOutboundCampaignsDivisionviews (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, List<string> id = null, string sortBy = null, string sortOrder = null)



Query a list of basic Campaign information objects

This returns a simplified version of a Campaign, consisting of name and division.

Requires ALL permissions: 

* outbound:campaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of basic Campaign information objects
                CampaignDivisionViewListing result = apiInstance.GetOutboundCampaignsDivisionviews(pageSize, pageNumber, filterType, name, id, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CampaignDivisionViewListing**](CampaignDivisionViewListing.html)

<a name="getoutboundcontactlist"></a>

## [**ContactList**](ContactList.html) GetOutboundContactlist (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)



Get a dialer contact list.

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            { 
                // Get a dialer contact list.
                ContactList result = apiInstance.GetOutboundContactlist(contactListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="getoutboundcontactlistcontact"></a>

## [**DialerContact**](DialerContact.html) GetOutboundContactlistContact (string contactListId, string contactId)



Get a contact.

Requires ANY permissions: 

* outbound:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID

            try
            { 
                // Get a contact.
                DialerContact result = apiInstance.GetOutboundContactlistContact(contactListId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
{: class="table table-striped"}

### Return type

[**DialerContact**](DialerContact.html)

<a name="getoutboundcontactlistexport"></a>

## [**ExportUri**](ExportUri.html) GetOutboundContactlistExport (string contactListId, string download = null)



Get the URI of a contact list export.

Requires ALL permissions: 

* outbound:contact:view
* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var download = download_example;  // string | Redirect to download uri (optional)  (default to "false")

            try
            { 
                // Get the URI of a contact list export.
                ExportUri result = apiInstance.GetOutboundContactlistExport(contactListId, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **download** | **string**| Redirect to download uri | [optional] [default to "false"] |
{: class="table table-striped"}

### Return type

[**ExportUri**](ExportUri.html)

<a name="getoutboundcontactlistimportstatus"></a>

## [**ImportStatus**](ImportStatus.html) GetOutboundContactlistImportstatus (string contactListId)



Get dialer contactList import status.

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistImportstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            { 
                // Get dialer contactList import status.
                ImportStatus result = apiInstance.GetOutboundContactlistImportstatus(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistImportstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.html)

<a name="getoutboundcontactlisttimezonemappingpreview"></a>

## [**TimeZoneMappingPreview**](TimeZoneMappingPreview.html) GetOutboundContactlistTimezonemappingpreview (string contactListId)



Preview the result of applying Automatic Time Zone Mapping to a contact list

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistTimezonemappingpreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            { 
                // Preview the result of applying Automatic Time Zone Mapping to a contact list
                TimeZoneMappingPreview result = apiInstance.GetOutboundContactlistTimezonemappingpreview(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistTimezonemappingpreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

[**TimeZoneMappingPreview**](TimeZoneMappingPreview.html)

<a name="getoutboundcontactlistfilter"></a>

## [**ContactListFilter**](ContactListFilter.html) GetOutboundContactlistfilter (string contactListFilterId)



Get Contact list filter

Requires ANY permissions: 

* outbound:contactListFilter:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistfilterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID

            try
            { 
                // Get Contact list filter
                ContactListFilter result = apiInstance.GetOutboundContactlistfilter(contactListFilterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |
{: class="table table-striped"}

### Return type

[**ContactListFilter**](ContactListFilter.html)

<a name="getoutboundcontactlistfilters"></a>

## [**ContactListFilterEntityListing**](ContactListFilterEntityListing.html) GetOutboundContactlistfilters (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListId = null)



Query Contact list filters

Requires ANY permissions: 

* outbound:contactListFilter:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistfiltersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 

            try
            { 
                // Query Contact list filters
                ContactListFilterEntityListing result = apiInstance.GetOutboundContactlistfilters(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder, contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistfilters: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
| **contactListId** | **string**| Contact List ID | [optional]  |
{: class="table table-striped"}

### Return type

[**ContactListFilterEntityListing**](ContactListFilterEntityListing.html)

<a name="getoutboundcontactlists"></a>

## [**ContactListEntityListing**](ContactListEntityListing.html) GetOutboundContactlists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, List<string> id = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null)



Query a list of contact lists.

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of contact lists.
                ContactListEntityListing result = apiInstance.GetOutboundContactlists(includeImportStatus, includeSize, pageSize, pageNumber, allowEmptyResult, filterType, name, id, divisionId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**ContactListEntityListing**](ContactListEntityListing.html)

<a name="getoutboundcontactlistsdivisionview"></a>

## [**ContactListDivisionView**](ContactListDivisionView.html) GetOutboundContactlistsDivisionview (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)



Get a basic ContactList information object

This returns a simplified version of a ContactList, consisting of the name, division, column names, phone columns, import status, and size.

Requires ALL permissions: 

* outbound:contactList:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistsDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contactlist ID
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            { 
                // Get a basic ContactList information object
                ContactListDivisionView result = apiInstance.GetOutboundContactlistsDivisionview(contactListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistsDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contactlist ID |  |
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ContactListDivisionView**](ContactListDivisionView.html)

<a name="getoutboundcontactlistsdivisionviews"></a>

## [**ContactListDivisionViewListing**](ContactListDivisionViewListing.html) GetOutboundContactlistsDivisionviews (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, List<string> id = null, string sortBy = null, string sortOrder = null)



Query a list of simplified contact list objects.

This return a simplified version of contact lists, consisting of the name, division, column names, phone columns, import status, and size.

Requires ALL permissions: 

* outbound:contactList:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of simplified contact list objects.
                ContactListDivisionViewListing result = apiInstance.GetOutboundContactlistsDivisionviews(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, id, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**ContactListDivisionViewListing**](ContactListDivisionViewListing.html)

<a name="getoutboundcontactlisttemplate"></a>

## [**ContactListTemplate**](ContactListTemplate.html) GetOutboundContactlisttemplate (string contactListTemplateId)



Get Contact List Template

Requires ANY permissions: 

* outbound:contactListTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlisttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListTemplateId = contactListTemplateId_example;  // string | ContactListTemplate ID

            try
            { 
                // Get Contact List Template
                ContactListTemplate result = apiInstance.GetOutboundContactlisttemplate(contactListTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlisttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListTemplateId** | **string**| ContactListTemplate ID |  |
{: class="table table-striped"}

### Return type

[**ContactListTemplate**](ContactListTemplate.html)

<a name="getoutboundcontactlisttemplates"></a>

## [**ContactListTemplateEntityListing**](ContactListTemplateEntityListing.html) GetOutboundContactlisttemplates (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)



Query a list of contact list templates

Requires ANY permissions: 

* outbound:contactListTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlisttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of contact list templates
                ContactListTemplateEntityListing result = apiInstance.GetOutboundContactlisttemplates(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlisttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**ContactListTemplateEntityListing**](ContactListTemplateEntityListing.html)

<a name="getoutbounddigitalruleset"></a>

## [**DigitalRuleSet**](DigitalRuleSet.html) GetOutboundDigitalruleset (string digitalRuleSetId)



Get an Outbound Digital Rule Set

Requires ANY permissions: 

* outbound:digitalRuleSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDigitalrulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var digitalRuleSetId = digitalRuleSetId_example;  // string | The Digital Rule Set ID

            try
            { 
                // Get an Outbound Digital Rule Set
                DigitalRuleSet result = apiInstance.GetOutboundDigitalruleset(digitalRuleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDigitalruleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **digitalRuleSetId** | **string**| The Digital Rule Set ID |  |
{: class="table table-striped"}

### Return type

[**DigitalRuleSet**](DigitalRuleSet.html)

<a name="getoutbounddigitalrulesets"></a>

## [**DigitalRuleSetEntityListing**](DigitalRuleSetEntityListing.html) GetOutboundDigitalrulesets (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, List<string> id = null)



Query a list of Outbound Digital Rule Sets

Requires ANY permissions: 

* outbound:digitalRuleSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDigitalrulesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | The field to sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | The direction to sort (optional)  (default to ascending)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | A list of digital rule set ids to bulk fetch (optional) 

            try
            { 
                // Query a list of Outbound Digital Rule Sets
                DigitalRuleSetEntityListing result = apiInstance.GetOutboundDigitalrulesets(pageSize, pageNumber, sortBy, sortOrder, name, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDigitalrulesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| The field to sort by | [optional] [default to name]<br />**Values**: name |
| **sortOrder** | **string**| The direction to sort | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string.html)| A list of digital rule set ids to bulk fetch | [optional]  |
{: class="table table-striped"}

### Return type

[**DigitalRuleSetEntityListing**](DigitalRuleSetEntityListing.html)

<a name="getoutbounddnclist"></a>

## [**DncList**](DncList.html) GetOutboundDnclist (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)



Get dialer DNC list

Requires ANY permissions: 

* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            { 
                // Get dialer DNC list
                DncList result = apiInstance.GetOutboundDnclist(dncListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="getoutbounddnclistexport"></a>

## [**ExportUri**](ExportUri.html) GetOutboundDnclistExport (string dncListId, string download = null)



Get the URI of a DNC list export.

Requires ALL permissions: 

* outbound:dnc:view
* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var download = download_example;  // string | Redirect to download uri (optional)  (default to "false")

            try
            { 
                // Get the URI of a DNC list export.
                ExportUri result = apiInstance.GetOutboundDnclistExport(dncListId, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **download** | **string**| Redirect to download uri | [optional] [default to "false"] |
{: class="table table-striped"}

### Return type

[**ExportUri**](ExportUri.html)

<a name="getoutbounddnclistimportstatus"></a>

## [**ImportStatus**](ImportStatus.html) GetOutboundDnclistImportstatus (string dncListId)



Get dialer dncList import status.

Requires ANY permissions: 

* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistImportstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            { 
                // Get dialer dncList import status.
                ImportStatus result = apiInstance.GetOutboundDnclistImportstatus(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistImportstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.html)

<a name="getoutbounddnclists"></a>

## [**DncListEntityListing**](DncListEntityListing.html) GetOutboundDnclists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string dncSourceType = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null)



Query dialer DNC lists

Requires ANY permissions: 

* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var dncSourceType = dncSourceType_example;  // string | DncSourceType (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            { 
                // Query dialer DNC lists
                DncListEntityListing result = apiInstance.GetOutboundDnclists(includeImportStatus, includeSize, pageSize, pageNumber, allowEmptyResult, filterType, name, dncSourceType, divisionId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **dncSourceType** | **string**| DncSourceType | [optional] <br />**Values**: rds, rds_custom, dnc.com, gryphon |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] <br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**DncListEntityListing**](DncListEntityListing.html)

<a name="getoutbounddnclistsdivisionview"></a>

## [**DncListDivisionView**](DncListDivisionView.html) GetOutboundDnclistsDivisionview (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)



Get a basic DncList information object

This returns a simplified version of a DncList, consisting of the name, division, import status, and size.

Requires ALL permissions: 

* outbound:dncList:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistsDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | Dnclist ID
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            { 
                // Get a basic DncList information object
                DncListDivisionView result = apiInstance.GetOutboundDnclistsDivisionview(dncListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistsDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| Dnclist ID |  |
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**DncListDivisionView**](DncListDivisionView.html)

<a name="getoutbounddnclistsdivisionviews"></a>

## [**DncListDivisionViewListing**](DncListDivisionViewListing.html) GetOutboundDnclistsDivisionviews (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string dncSourceType = null, List<string> id = null, string sortBy = null, string sortOrder = null)



Query a list of simplified dnc list objects.

This return a simplified version of dnc lists, consisting of the name, division, import status, and size.

Requires ALL permissions: 

* outbound:dncList:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var dncSourceType = dncSourceType_example;  // string | DncSourceType (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of simplified dnc list objects.
                DncListDivisionViewListing result = apiInstance.GetOutboundDnclistsDivisionviews(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, dncSourceType, id, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **dncSourceType** | **string**| DncSourceType | [optional] <br />**Values**: rds, rds_custom, dnc.com, gryphon |
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**DncListDivisionViewListing**](DncListDivisionViewListing.html)

<a name="getoutboundevent"></a>

## [**EventLog**](EventLog.html) GetOutboundEvent (string eventId)



Get Dialer Event

Requires ANY permissions: 

* outbound:eventLog:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundEventExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var eventId = eventId_example;  // string | Event Log ID

            try
            { 
                // Get Dialer Event
                EventLog result = apiInstance.GetOutboundEvent(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **eventId** | **string**| Event Log ID |  |
{: class="table table-striped"}

### Return type

[**EventLog**](EventLog.html)

<a name="getoutboundevents"></a>

## [**DialerEventEntityListing**](DialerEventEntityListing.html) GetOutboundEvents (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null)



Query Event Logs

Requires ANY permissions: 

* outbound:eventLog:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundEventsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var category = category_example;  // string | Category (optional) 
            var level = level_example;  // string | Level (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query Event Logs
                DialerEventEntityListing result = apiInstance.GetOutboundEvents(pageSize, pageNumber, filterType, category, level, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **category** | **string**| Category | [optional]  |
| **level** | **string**| Level | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**DialerEventEntityListing**](DialerEventEntityListing.html)

<a name="getoutboundfilespecificationtemplate"></a>

## [**FileSpecificationTemplate**](FileSpecificationTemplate.html) GetOutboundFilespecificationtemplate (string fileSpecificationTemplateId)



Get File Specification Template

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundFilespecificationtemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var fileSpecificationTemplateId = fileSpecificationTemplateId_example;  // string | File Specification Template ID

            try
            { 
                // Get File Specification Template
                FileSpecificationTemplate result = apiInstance.GetOutboundFilespecificationtemplate(fileSpecificationTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundFilespecificationtemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **fileSpecificationTemplateId** | **string**| File Specification Template ID |  |
{: class="table table-striped"}

### Return type

[**FileSpecificationTemplate**](FileSpecificationTemplate.html)

<a name="getoutboundfilespecificationtemplates"></a>

## [**FileSpecificationTemplateEntityListing**](FileSpecificationTemplateEntityListing.html) GetOutboundFilespecificationtemplates (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)



Query File Specification Templates

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundFilespecificationtemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query File Specification Templates
                FileSpecificationTemplateEntityListing result = apiInstance.GetOutboundFilespecificationtemplates(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundFilespecificationtemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**FileSpecificationTemplateEntityListing**](FileSpecificationTemplateEntityListing.html)

<a name="getoutboundimporttemplate"></a>

## [**ImportTemplate**](ImportTemplate.html) GetOutboundImporttemplate (string importTemplateId, bool? includeImportStatus = null)



Get Import Template

Requires ANY permissions: 

* outbound:importTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundImporttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var importTemplateId = importTemplateId_example;  // string | Import Template ID
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)

            try
            { 
                // Get Import Template
                ImportTemplate result = apiInstance.GetOutboundImporttemplate(importTemplateId, includeImportStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundImporttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importTemplateId** | **string**| Import Template ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ImportTemplate**](ImportTemplate.html)

<a name="getoutboundimporttemplateimportstatus"></a>

## [**ImportStatus**](ImportStatus.html) GetOutboundImporttemplateImportstatus (string importTemplateId, string listNamePrefix = null)



Get the import status for an import template.

Requires ANY permissions: 

* outbound:importTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundImporttemplateImportstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var importTemplateId = importTemplateId_example;  // string | importTemplateId
            var listNamePrefix = listNamePrefix_example;  // string | listNamePrefix (optional) 

            try
            { 
                // Get the import status for an import template.
                ImportStatus result = apiInstance.GetOutboundImporttemplateImportstatus(importTemplateId, listNamePrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundImporttemplateImportstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importTemplateId** | **string**| importTemplateId |  |
| **listNamePrefix** | **string**| listNamePrefix | [optional]  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.html)

<a name="getoutboundimporttemplates"></a>

## [**ImportTemplateEntityListing**](ImportTemplateEntityListing.html) GetOutboundImporttemplates (bool? includeImportStatus = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListTemplateId = null)



Query Import Templates

Requires ANY permissions: 

* outbound:importTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundImporttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            var contactListTemplateId = contactListTemplateId_example;  // string | Contact List Template ID (optional) 

            try
            { 
                // Query Import Templates
                ImportTemplateEntityListing result = apiInstance.GetOutboundImporttemplates(includeImportStatus, pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder, contactListTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundImporttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
| **contactListTemplateId** | **string**| Contact List Template ID | [optional]  |
{: class="table table-striped"}

### Return type

[**ImportTemplateEntityListing**](ImportTemplateEntityListing.html)

<a name="getoutboundmessagingcampaign"></a>

## [**MessagingCampaign**](MessagingCampaign.html) GetOutboundMessagingcampaign (string messagingCampaignId)



Get an Outbound Messaging Campaign

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Get an Outbound Messaging Campaign
                MessagingCampaign result = apiInstance.GetOutboundMessagingcampaign(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |
{: class="table table-striped"}

### Return type

[**MessagingCampaign**](MessagingCampaign.html)

<a name="getoutboundmessagingcampaigndiagnostics"></a>

## [**MessagingCampaignDiagnostics**](MessagingCampaignDiagnostics.html) GetOutboundMessagingcampaignDiagnostics (string messagingCampaignId)



Get messaging campaign diagnostics

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignDiagnosticsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Get messaging campaign diagnostics
                MessagingCampaignDiagnostics result = apiInstance.GetOutboundMessagingcampaignDiagnostics(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaignDiagnostics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |
{: class="table table-striped"}

### Return type

[**MessagingCampaignDiagnostics**](MessagingCampaignDiagnostics.html)

<a name="getoutboundmessagingcampaignprogress"></a>

## [**CampaignProgress**](CampaignProgress.html) GetOutboundMessagingcampaignProgress (string messagingCampaignId)



Get messaging campaign's progress

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Get messaging campaign's progress
                CampaignProgress result = apiInstance.GetOutboundMessagingcampaignProgress(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaignProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignProgress**](CampaignProgress.html)

<a name="getoutboundmessagingcampaigns"></a>

## [**MessagingCampaignEntityListing**](MessagingCampaignEntityListing.html) GetOutboundMessagingcampaigns (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string contactListId = null, List<string> divisionId = null, string type = null, string senderSmsPhoneNumber = null, List<string> id = null)



Query a list of Messaging Campaigns

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | The field to sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | The direction to sort (optional)  (default to ascending)
            var name = name_example;  // string | Name (optional) 
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var type = type_example;  // string | Campaign Type (optional) 
            var senderSmsPhoneNumber = senderSmsPhoneNumber_example;  // string | Sender SMS Phone Number (optional) 
            var id = new List<string>(); // List<string> | A list of messaging campaign ids to bulk fetch (optional) 

            try
            { 
                // Query a list of Messaging Campaigns
                MessagingCampaignEntityListing result = apiInstance.GetOutboundMessagingcampaigns(pageSize, pageNumber, sortBy, sortOrder, name, contactListId, divisionId, type, senderSmsPhoneNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| The field to sort by | [optional] [default to name]<br />**Values**: campaignStatus, name, type |
| **sortOrder** | **string**| The direction to sort | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
| **contactListId** | **string**| Contact List ID | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
| **type** | **string**| Campaign Type | [optional] <br />**Values**: EMAIL, SMS |
| **senderSmsPhoneNumber** | **string**| Sender SMS Phone Number | [optional]  |
| **id** | [**List<string>**](string.html)| A list of messaging campaign ids to bulk fetch | [optional]  |
{: class="table table-striped"}

### Return type

[**MessagingCampaignEntityListing**](MessagingCampaignEntityListing.html)

<a name="getoutboundmessagingcampaignsdivisionview"></a>

## [**MessagingCampaignDivisionView**](MessagingCampaignDivisionView.html) GetOutboundMessagingcampaignsDivisionview (string messagingCampaignId)



Get a basic Messaging Campaign information object

This returns a simplified version of a Messaging Campaign, consisting of id, name, and division.

Requires ANY permissions: 

* outbound:messagingCampaign:search
* outbound:emailCampaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignsDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Get a basic Messaging Campaign information object
                MessagingCampaignDivisionView result = apiInstance.GetOutboundMessagingcampaignsDivisionview(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaignsDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |
{: class="table table-striped"}

### Return type

[**MessagingCampaignDivisionView**](MessagingCampaignDivisionView.html)

<a name="getoutboundmessagingcampaignsdivisionviews"></a>

## [**MessagingCampaignDivisionViewEntityListing**](MessagingCampaignDivisionViewEntityListing.html) GetOutboundMessagingcampaignsDivisionviews (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, string type = null, List<string> id = null, string senderSmsPhoneNumber = null)



Query a list of basic Messaging Campaign information objects

This returns a listing of simplified Messaging Campaigns, each consisting of id, name, and division.

Requires ANY permissions: 

* outbound:messagingCampaign:search
* outbound:emailCampaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | The direction to sort (optional)  (default to a)
            var name = name_example;  // string | Name (optional) 
            var type = type_example;  // string | Campaign Type (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var senderSmsPhoneNumber = senderSmsPhoneNumber_example;  // string | Sender SMS Phone Number (optional) 

            try
            { 
                // Query a list of basic Messaging Campaign information objects
                MessagingCampaignDivisionViewEntityListing result = apiInstance.GetOutboundMessagingcampaignsDivisionviews(pageSize, pageNumber, sortOrder, name, type, id, senderSmsPhoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaignsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| The direction to sort | [optional] [default to a]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
| **type** | **string**| Campaign Type | [optional] <br />**Values**: EMAIL, SMS |
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **senderSmsPhoneNumber** | **string**| Sender SMS Phone Number | [optional]  |
{: class="table table-striped"}

### Return type

[**MessagingCampaignDivisionViewEntityListing**](MessagingCampaignDivisionViewEntityListing.html)

<a name="getoutboundruleset"></a>

## [**RuleSet**](RuleSet.html) GetOutboundRuleset (string ruleSetId)



Get a Rule Set by ID.

Requires ANY permissions: 

* outbound:ruleSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundRulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID

            try
            { 
                // Get a Rule Set by ID.
                RuleSet result = apiInstance.GetOutboundRuleset(ruleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundRuleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="getoutboundrulesets"></a>

## [**RuleSetEntityListing**](RuleSetEntityListing.html) GetOutboundRulesets (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)



Query a list of Rule Sets.

Requires ANY permissions: 

* outbound:ruleSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundRulesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of Rule Sets.
                RuleSetEntityListing result = apiInstance.GetOutboundRulesets(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundRulesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**RuleSetEntityListing**](RuleSetEntityListing.html)

<a name="getoutboundschedulescampaign"></a>

## [**CampaignSchedule**](CampaignSchedule.html) GetOutboundSchedulesCampaign (string campaignId)



Get a dialer campaign schedule.

Requires ANY permissions: 

* outbound:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get a dialer campaign schedule.
                CampaignSchedule result = apiInstance.GetOutboundSchedulesCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignSchedule**](CampaignSchedule.html)

<a name="getoutboundschedulescampaigns"></a>

## [**List&lt;CampaignSchedule&gt;**](CampaignSchedule.html) GetOutboundSchedulesCampaigns ()



Query for a list of dialer campaign schedules.

Requires ANY permissions: 

* outbound:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesCampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Query for a list of dialer campaign schedules.
                List<CampaignSchedule> result = apiInstance.GetOutboundSchedulesCampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**List<CampaignSchedule>**](CampaignSchedule.html)

<a name="getoutboundschedulesemailcampaign"></a>

## [**EmailCampaignSchedule**](EmailCampaignSchedule.html) GetOutboundSchedulesEmailcampaign (string emailCampaignId)



Get an email campaign schedule.

Requires ANY permissions: 

* outbound:emailCampaignSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesEmailcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var emailCampaignId = emailCampaignId_example;  // string | Email Campaign ID

            try
            { 
                // Get an email campaign schedule.
                EmailCampaignSchedule result = apiInstance.GetOutboundSchedulesEmailcampaign(emailCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesEmailcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailCampaignId** | **string**| Email Campaign ID |  |
{: class="table table-striped"}

### Return type

[**EmailCampaignSchedule**](EmailCampaignSchedule.html)

<a name="getoutboundschedulesemailcampaigns"></a>

## [**EmailCampaignScheduleEntityListing**](EmailCampaignScheduleEntityListing.html) GetOutboundSchedulesEmailcampaigns ()



Query for a list of email campaign schedules.

Requires ANY permissions: 

* outbound:emailCampaignSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesEmailcampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Query for a list of email campaign schedules.
                EmailCampaignScheduleEntityListing result = apiInstance.GetOutboundSchedulesEmailcampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesEmailcampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**EmailCampaignScheduleEntityListing**](EmailCampaignScheduleEntityListing.html)

<a name="getoutboundschedulesmessagingcampaign"></a>

## [**MessagingCampaignSchedule**](MessagingCampaignSchedule.html) GetOutboundSchedulesMessagingcampaign (string messagingCampaignId)



Get a messaging campaign schedule.

Requires ANY permissions: 

* outbound:messagingCampaignSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | Messaging Campaign ID

            try
            { 
                // Get a messaging campaign schedule.
                MessagingCampaignSchedule result = apiInstance.GetOutboundSchedulesMessagingcampaign(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| Messaging Campaign ID |  |
{: class="table table-striped"}

### Return type

[**MessagingCampaignSchedule**](MessagingCampaignSchedule.html)

<a name="getoutboundschedulesmessagingcampaigns"></a>

## [**MessagingCampaignScheduleEntityListing**](MessagingCampaignScheduleEntityListing.html) GetOutboundSchedulesMessagingcampaigns ()



Query for a list of messaging campaign schedules.

Requires ANY permissions: 

* outbound:messagingCampaignSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesMessagingcampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Query for a list of messaging campaign schedules.
                MessagingCampaignScheduleEntityListing result = apiInstance.GetOutboundSchedulesMessagingcampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesMessagingcampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**MessagingCampaignScheduleEntityListing**](MessagingCampaignScheduleEntityListing.html)

<a name="getoutboundschedulessequence"></a>

## [**SequenceSchedule**](SequenceSchedule.html) GetOutboundSchedulesSequence (string sequenceId)



Get a dialer sequence schedule.

Requires ANY permissions: 

* outbound:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID

            try
            { 
                // Get a dialer sequence schedule.
                SequenceSchedule result = apiInstance.GetOutboundSchedulesSequence(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
{: class="table table-striped"}

### Return type

[**SequenceSchedule**](SequenceSchedule.html)

<a name="getoutboundschedulessequences"></a>

## [**List&lt;SequenceSchedule&gt;**](SequenceSchedule.html) GetOutboundSchedulesSequences ()



Query for a list of dialer sequence schedules.

Requires ANY permissions: 

* outbound:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesSequencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Query for a list of dialer sequence schedules.
                List<SequenceSchedule> result = apiInstance.GetOutboundSchedulesSequences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesSequences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**List<SequenceSchedule>**](SequenceSchedule.html)

<a name="getoutboundsequence"></a>

## [**CampaignSequence**](CampaignSequence.html) GetOutboundSequence (string sequenceId)



Get a dialer campaign sequence.

Requires ANY permissions: 

* outbound:campaignSequence:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID

            try
            { 
                // Get a dialer campaign sequence.
                CampaignSequence result = apiInstance.GetOutboundSequence(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="getoutboundsequences"></a>

## [**CampaignSequenceEntityListing**](CampaignSequenceEntityListing.html) GetOutboundSequences (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)



Query a list of dialer campaign sequences.

Requires ANY permissions: 

* outbound:campaignSequence:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSequencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of dialer campaign sequences.
                CampaignSequenceEntityListing result = apiInstance.GetOutboundSequences(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSequences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CampaignSequenceEntityListing**](CampaignSequenceEntityListing.html)

<a name="getoutboundsettings"></a>

## [**OutboundSettings**](OutboundSettings.html) GetOutboundSettings ()



Get the outbound settings for this organization

Requires ANY permissions: 

* outbound:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Get the outbound settings for this organization
                OutboundSettings result = apiInstance.GetOutboundSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**OutboundSettings**](OutboundSettings.html)

<a name="getoutboundwrapupcodemappings"></a>

## [**WrapUpCodeMapping**](WrapUpCodeMapping.html) GetOutboundWrapupcodemappings ()



Get the Dialer wrap up code mapping.

Requires ANY permissions: 

* outbound:wrapUpCodeMapping:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundWrapupcodemappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Get the Dialer wrap up code mapping.
                WrapUpCodeMapping result = apiInstance.GetOutboundWrapupcodemappings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundWrapupcodemappings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping.html)

<a name="patchoutbounddnclistcustomexclusioncolumns"></a>

## void PatchOutboundDnclistCustomexclusioncolumns (string dncListId, DncPatchCustomExclusionColumnsRequest body)



Add entries to or delete entries from a DNC list.

Only Internal DNC lists may be deleted from

Requires ANY permissions: 

* outbound:dnc:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundDnclistCustomexclusioncolumnsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncPatchCustomExclusionColumnsRequest(); // DncPatchCustomExclusionColumnsRequest | DNC Custom exclusion column entries

            try
            { 
                // Add entries to or delete entries from a DNC list.
                apiInstance.PatchOutboundDnclistCustomexclusioncolumns(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundDnclistCustomexclusioncolumns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncPatchCustomExclusionColumnsRequest**](DncPatchCustomExclusionColumnsRequest.html)| DNC Custom exclusion column entries |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchoutbounddnclistemailaddresses"></a>

## void PatchOutboundDnclistEmailaddresses (string dncListId, DncPatchEmailsRequest body)



Add emails to or Delete emails from a DNC list.

Only Internal DNC lists may be added to or deleted from

Requires ANY permissions: 

* outbound:dnc:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundDnclistEmailaddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncPatchEmailsRequest(); // DncPatchEmailsRequest | DNC Emails

            try
            { 
                // Add emails to or Delete emails from a DNC list.
                apiInstance.PatchOutboundDnclistEmailaddresses(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundDnclistEmailaddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncPatchEmailsRequest**](DncPatchEmailsRequest.html)| DNC Emails |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchoutbounddnclistphonenumbers"></a>

## void PatchOutboundDnclistPhonenumbers (string dncListId, DncPatchPhoneNumbersRequest body)



Add numbers to or delete numbers from a DNC list.

Only Internal DNC lists may be added to deleted from

Requires ANY permissions: 

* outbound:dnc:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundDnclistPhonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncPatchPhoneNumbersRequest(); // DncPatchPhoneNumbersRequest | DNC Phone Numbers

            try
            { 
                // Add numbers to or delete numbers from a DNC list.
                apiInstance.PatchOutboundDnclistPhonenumbers(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundDnclistPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncPatchPhoneNumbersRequest**](DncPatchPhoneNumbersRequest.html)| DNC Phone Numbers |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchoutboundsettings"></a>

## void PatchOutboundSettings (OutboundSettings body)



Update the outbound settings for this organization

Requires ANY permissions: 

* outbound:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new OutboundSettings(); // OutboundSettings | outboundSettings

            try
            { 
                // Update the outbound settings for this organization
                apiInstance.PatchOutboundSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutboundSettings**](OutboundSettings.html)| outboundSettings |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postoutboundattemptlimits"></a>

## [**AttemptLimits**](AttemptLimits.html) PostOutboundAttemptlimits (AttemptLimits body)



Create attempt limits

Requires ANY permissions: 

* outbound:attemptLimits:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundAttemptlimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new AttemptLimits(); // AttemptLimits | AttemptLimits

            try
            { 
                // Create attempt limits
                AttemptLimits result = apiInstance.PostOutboundAttemptlimits(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundAttemptlimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AttemptLimits**](AttemptLimits.html)| AttemptLimits |  |
{: class="table table-striped"}

### Return type

[**AttemptLimits**](AttemptLimits.html)

<a name="postoutboundaudits"></a>

## [**AuditSearchResult**](AuditSearchResult.html) PostOutboundAudits (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Retrieves audits for dialer. (Deprecated)

This endpoint is deprecated as a result of this functionality being moved to the Audit Service. Please use \"/api/v2/audits/query\" instead.

Requires ANY permissions: 

* outbound:audit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundAuditsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new DialerAuditRequest(); // DialerAuditRequest | AuditSearch
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "entity.name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ascending")
            var facetsOnly = true;  // bool? | Facets only (optional)  (default to false)

            try
            { 
                // Retrieves audits for dialer. (Deprecated)
                AuditSearchResult result = apiInstance.PostOutboundAudits(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundAudits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DialerAuditRequest**](DialerAuditRequest.html)| AuditSearch |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "entity.name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ascending"] |
| **facetsOnly** | **bool?**| Facets only | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AuditSearchResult**](AuditSearchResult.html)

<a name="postoutboundcallabletimesets"></a>

## [**CallableTimeSet**](CallableTimeSet.html) PostOutboundCallabletimesets (CallableTimeSet body)



Create callable time set

Requires ANY permissions: 

* outbound:callableTimeSet:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCallabletimesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet

            try
            { 
                // Create callable time set
                CallableTimeSet result = apiInstance.PostOutboundCallabletimesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCallabletimesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CallableTimeSet**](CallableTimeSet.html)| DialerCallableTimeSet |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="postoutboundcallanalysisresponsesets"></a>

## [**ResponseSet**](ResponseSet.html) PostOutboundCallanalysisresponsesets (ResponseSet body)



Create a dialer call analysis response set.

Requires ANY permissions: 

* outbound:responseSet:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCallanalysisresponsesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ResponseSet(); // ResponseSet | ResponseSet

            try
            { 
                // Create a dialer call analysis response set.
                ResponseSet result = apiInstance.PostOutboundCallanalysisresponsesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCallanalysisresponsesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResponseSet**](ResponseSet.html)| ResponseSet |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="postoutboundcampaignagentownedmappingpreview"></a>

## **Object** PostOutboundCampaignAgentownedmappingpreview (string campaignId)



Initiate request for a preview of how agents will be mapped to this campaign's contact list.

Requires ALL permissions: 

* outbound:campaign:view
* outbound:contact:view
* directory:user:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignAgentownedmappingpreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Initiate request for a preview of how agents will be mapped to this campaign's contact list.
                Object result = apiInstance.PostOutboundCampaignAgentownedmappingpreview(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignAgentownedmappingpreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="postoutboundcampaigncallbackschedule"></a>

## [**ContactCallbackRequest**](ContactCallbackRequest.html) PostOutboundCampaignCallbackSchedule (string campaignId, ContactCallbackRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Schedule a Callback for a Dialer Campaign (Deprecated)

This endpoint is deprecated and may have unexpected results. Please use \"/conversations/{conversationId}/participants/{participantId}/callbacks instead.\"

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignCallbackScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new ContactCallbackRequest(); // ContactCallbackRequest | ContactCallbackRequest

            try
            { 
                // Schedule a Callback for a Dialer Campaign (Deprecated)
                ContactCallbackRequest result = apiInstance.PostOutboundCampaignCallbackSchedule(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignCallbackSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**ContactCallbackRequest**](ContactCallbackRequest.html)| ContactCallbackRequest |  |
{: class="table table-striped"}

### Return type

[**ContactCallbackRequest**](ContactCallbackRequest.html)

<a name="postoutboundcampaignrules"></a>

## [**CampaignRule**](CampaignRule.html) PostOutboundCampaignrules (CampaignRule body)



Create Campaign Rule

Requires ANY permissions: 

* outbound:campaignRule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignrulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new CampaignRule(); // CampaignRule | CampaignRule

            try
            { 
                // Create Campaign Rule
                CampaignRule result = apiInstance.PostOutboundCampaignrules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignrules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CampaignRule**](CampaignRule.html)| CampaignRule |  |
{: class="table table-striped"}

### Return type

[**CampaignRule**](CampaignRule.html)

<a name="postoutboundcampaigns"></a>

## [**Campaign**](Campaign.html) PostOutboundCampaigns (Campaign body)



Create a campaign.

Requires ANY permissions: 

* outbound:campaign:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new Campaign(); // Campaign | Campaign

            try
            { 
                // Create a campaign.
                Campaign result = apiInstance.PostOutboundCampaigns(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Campaign**](Campaign.html)| Campaign |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="postoutboundcampaignsprogress"></a>

## [**List&lt;CampaignProgress&gt;**](CampaignProgress.html) PostOutboundCampaignsProgress (List<string> body)



Get progress for a list of campaigns

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignsProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new List<string>(); // List<string> | Campaign IDs

            try
            { 
                // Get progress for a list of campaigns
                List<CampaignProgress> result = apiInstance.PostOutboundCampaignsProgress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignsProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string.html)| Campaign IDs |  |
{: class="table table-striped"}

### Return type

[**List<CampaignProgress>**](CampaignProgress.html)

<a name="postoutboundcontactlistclear"></a>

## void PostOutboundContactlistClear (string contactListId)



Deletes all contacts out of a list. All outstanding recalls or rule-scheduled callbacks for non-preview campaigns configured with the contactlist will be cancelled.

Requires ANY permissions: 

* outbound:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistClearExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID

            try
            { 
                // Deletes all contacts out of a list. All outstanding recalls or rule-scheduled callbacks for non-preview campaigns configured with the contactlist will be cancelled.
                apiInstance.PostOutboundContactlistClear(contactListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistClear: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postoutboundcontactlistcontacts"></a>

## [**List&lt;DialerContact&gt;**](DialerContact.html) PostOutboundContactlistContacts (string contactListId, List<WritableDialerContact> body, bool? priority = null, bool? clearSystemData = null, bool? doNotQueue = null)



Add contacts to a contact list.

Requires ANY permissions: 

* outbound:contact:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new List<WritableDialerContact>(); // List<WritableDialerContact> | Contact
            var priority = true;  // bool? | Contact priority. True means the contact(s) will be dialed next; false means the contact will go to the end of the contact queue. (optional) 
            var clearSystemData = true;  // bool? | Clear system data. True means the system columns (attempts, callable status, etc) stored on the contact will be cleared if the contact already exists; false means they won't. (optional) 
            var doNotQueue = true;  // bool? | Do not queue. True means that updated contacts will not have their positions in the queue altered, so contacts that have already been dialed will not be redialed. For new contacts, this parameter has no effect; False means that updated contacts will be re-queued, according to the 'priority' parameter. (optional) 

            try
            { 
                // Add contacts to a contact list.
                List<DialerContact> result = apiInstance.PostOutboundContactlistContacts(contactListId, body, priority, clearSystemData, doNotQueue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**List<WritableDialerContact>**](WritableDialerContact.html)| Contact |  |
| **priority** | **bool?**| Contact priority. True means the contact(s) will be dialed next; false means the contact will go to the end of the contact queue. | [optional]  |
| **clearSystemData** | **bool?**| Clear system data. True means the system columns (attempts, callable status, etc) stored on the contact will be cleared if the contact already exists; false means they won&#39;t. | [optional]  |
| **doNotQueue** | **bool?**| Do not queue. True means that updated contacts will not have their positions in the queue altered, so contacts that have already been dialed will not be redialed. For new contacts, this parameter has no effect; False means that updated contacts will be re-queued, according to the &#39;priority&#39; parameter. | [optional]  |
{: class="table table-striped"}

### Return type

[**List<DialerContact>**](DialerContact.html)

<a name="postoutboundcontactlistcontactsbulk"></a>

## [**List&lt;DialerContact&gt;**](DialerContact.html) PostOutboundContactlistContactsBulk (string contactListId, List<string> body)



Get contacts from a contact list.

Requires ANY permissions: 

* outbound:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new List<string>(); // List<string> | ContactIds to get.

            try
            { 
                // Get contacts from a contact list.
                List<DialerContact> result = apiInstance.PostOutboundContactlistContactsBulk(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContactsBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**List<string>**](string.html)| ContactIds to get. |  |
{: class="table table-striped"}

### Return type

[**List<DialerContact>**](DialerContact.html)

<a name="postoutboundcontactlistcontactsbulkremove"></a>

## [**ContactsBulkOperationJob**](ContactsBulkOperationJob.html) PostOutboundContactlistContactsBulkRemove (string contactListId, ContactBulkSearchParameters body)



Start an async job to delete contacts using a filter.

Requires ANY permissions: 

* outbound:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsBulkRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new ContactBulkSearchParameters(); // ContactBulkSearchParameters | Contact filter information.

            try
            { 
                // Start an async job to delete contacts using a filter.
                ContactsBulkOperationJob result = apiInstance.PostOutboundContactlistContactsBulkRemove(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContactsBulkRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**ContactBulkSearchParameters**](ContactBulkSearchParameters.html)| Contact filter information. |  |
{: class="table table-striped"}

### Return type

[**ContactsBulkOperationJob**](ContactsBulkOperationJob.html)

<a name="postoutboundcontactlistcontactsbulkupdate"></a>

## [**ContactsBulkOperationJob**](ContactsBulkOperationJob.html) PostOutboundContactlistContactsBulkUpdate (string contactListId, ContactBulkEditRequest body)



Start an async job to bulk edit contacts.

Requires ANY permissions: 

* outbound:contact:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsBulkUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new ContactBulkEditRequest(); // ContactBulkEditRequest | Contact bulk edit request information.

            try
            { 
                // Start an async job to bulk edit contacts.
                ContactsBulkOperationJob result = apiInstance.PostOutboundContactlistContactsBulkUpdate(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContactsBulkUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**ContactBulkEditRequest**](ContactBulkEditRequest.html)| Contact bulk edit request information. |  |
{: class="table table-striped"}

### Return type

[**ContactsBulkOperationJob**](ContactsBulkOperationJob.html)

<a name="postoutboundcontactlistcontactssearch"></a>

## [**ContactListingResponse**](ContactListingResponse.html) PostOutboundContactlistContactsSearch (string contactListId, ContactListingRequest body)



Query contacts from a contact list.

Requires ANY permissions: 

* outbound:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new ContactListingRequest(); // ContactListingRequest | Contact search parameters.

            try
            { 
                // Query contacts from a contact list.
                ContactListingResponse result = apiInstance.PostOutboundContactlistContactsSearch(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContactsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**ContactListingRequest**](ContactListingRequest.html)| Contact search parameters. |  |
{: class="table table-striped"}

### Return type

[**ContactListingResponse**](ContactListingResponse.html)

<a name="postoutboundcontactlistexport"></a>

## [**DomainEntityRef**](DomainEntityRef.html) PostOutboundContactlistExport (string contactListId, ContactsExportRequest body = null)



Initiate the export of a contact list.

Returns 200 if received OK.

Requires ALL permissions: 

* outbound:contact:view
* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var body = new ContactsExportRequest(); // ContactsExportRequest | Export information to get (optional) 

            try
            { 
                // Initiate the export of a contact list.
                DomainEntityRef result = apiInstance.PostOutboundContactlistExport(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **body** | [**ContactsExportRequest**](ContactsExportRequest.html)| Export information to get | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainEntityRef**](DomainEntityRef.html)

<a name="postoutboundcontactlistfilters"></a>

## [**ContactListFilter**](ContactListFilter.html) PostOutboundContactlistfilters (ContactListFilter body)



Create Contact List Filter

Requires ANY permissions: 

* outbound:contactListFilter:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistfiltersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter

            try
            { 
                // Create Contact List Filter
                ContactListFilter result = apiInstance.PostOutboundContactlistfilters(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistfilters: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListFilter**](ContactListFilter.html)| ContactListFilter |  |
{: class="table table-striped"}

### Return type

[**ContactListFilter**](ContactListFilter.html)

<a name="postoutboundcontactlistfiltersbulkretrieve"></a>

## [**ContactListFilterEntityListing**](ContactListFilterEntityListing.html) PostOutboundContactlistfiltersBulkRetrieve (ContactListFilterBulkRetrieveBody body)



Retrieve multiple contact list filters

Requires ANY permissions: 

* outbound:contactListFilter:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistfiltersBulkRetrieveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListFilterBulkRetrieveBody(); // ContactListFilterBulkRetrieveBody | The contact list filters to retrieve

            try
            { 
                // Retrieve multiple contact list filters
                ContactListFilterEntityListing result = apiInstance.PostOutboundContactlistfiltersBulkRetrieve(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistfiltersBulkRetrieve: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListFilterBulkRetrieveBody**](ContactListFilterBulkRetrieveBody.html)| The contact list filters to retrieve |  |
{: class="table table-striped"}

### Return type

[**ContactListFilterEntityListing**](ContactListFilterEntityListing.html)

<a name="postoutboundcontactlistfilterspreview"></a>

## [**FilterPreviewResponse**](FilterPreviewResponse.html) PostOutboundContactlistfiltersPreview (ContactListFilter body)



Get a preview of the output of a contact list filter

Requires ANY permissions: 

* outbound:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistfiltersPreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter

            try
            { 
                // Get a preview of the output of a contact list filter
                FilterPreviewResponse result = apiInstance.PostOutboundContactlistfiltersPreview(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistfiltersPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListFilter**](ContactListFilter.html)| ContactListFilter |  |
{: class="table table-striped"}

### Return type

[**FilterPreviewResponse**](FilterPreviewResponse.html)

<a name="postoutboundcontactlists"></a>

## [**ContactList**](ContactList.html) PostOutboundContactlists (ContactList body)



Create a contact List.

Requires ANY permissions: 

* outbound:contactList:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactList(); // ContactList | ContactList

            try
            { 
                // Create a contact List.
                ContactList result = apiInstance.PostOutboundContactlists(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactList**](ContactList.html)| ContactList |  |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="postoutboundcontactlisttemplates"></a>

## [**ContactListTemplate**](ContactListTemplate.html) PostOutboundContactlisttemplates (ContactListTemplate body)



Create Contact List Template

Requires ANY permissions: 

* outbound:contactListTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlisttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListTemplate(); // ContactListTemplate | ContactListTemplate

            try
            { 
                // Create Contact List Template
                ContactListTemplate result = apiInstance.PostOutboundContactlisttemplates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlisttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListTemplate**](ContactListTemplate.html)| ContactListTemplate |  |
{: class="table table-striped"}

### Return type

[**ContactListTemplate**](ContactListTemplate.html)

<a name="postoutboundcontactlisttemplatesbulkadd"></a>

## [**ContactListTemplateEntityListing**](ContactListTemplateEntityListing.html) PostOutboundContactlisttemplatesBulkAdd (List<ContactListTemplate> body)



Add multiple contact list templates

Requires ANY permissions: 

* outbound:contactListTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlisttemplatesBulkAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new List<ContactListTemplate>(); // List<ContactListTemplate> | contact list template(s) to add

            try
            { 
                // Add multiple contact list templates
                ContactListTemplateEntityListing result = apiInstance.PostOutboundContactlisttemplatesBulkAdd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlisttemplatesBulkAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<ContactListTemplate>**](ContactListTemplate.html)| contact list template(s) to add |  |
{: class="table table-striped"}

### Return type

[**ContactListTemplateEntityListing**](ContactListTemplateEntityListing.html)

<a name="postoutboundcontactlisttemplatesbulkretrieve"></a>

## [**ContactListTemplateEntityListing**](ContactListTemplateEntityListing.html) PostOutboundContactlisttemplatesBulkRetrieve (ContactListTemplateBulkRetrieveBody body)



Get multiple contact list templates

Requires ANY permissions: 

* outbound:contactListTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlisttemplatesBulkRetrieveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListTemplateBulkRetrieveBody(); // ContactListTemplateBulkRetrieveBody | contact list templates to get

            try
            { 
                // Get multiple contact list templates
                ContactListTemplateEntityListing result = apiInstance.PostOutboundContactlisttemplatesBulkRetrieve(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlisttemplatesBulkRetrieve: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListTemplateBulkRetrieveBody**](ContactListTemplateBulkRetrieveBody.html)| contact list templates to get |  |
{: class="table table-striped"}

### Return type

[**ContactListTemplateEntityListing**](ContactListTemplateEntityListing.html)

<a name="postoutboundconversationdnc"></a>

## void PostOutboundConversationDnc (string conversationId)



Add phone numbers to a Dialer DNC list.

Requires ANY permissions: 

* outbound:dnc:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundConversationDncExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var conversationId = conversationId_example;  // string | Conversation ID

            try
            { 
                // Add phone numbers to a Dialer DNC list.
                apiInstance.PostOutboundConversationDnc(conversationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundConversationDnc: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postoutbounddigitalrulesets"></a>

## [**DigitalRuleSet**](DigitalRuleSet.html) PostOutboundDigitalrulesets (DigitalRuleSet body)



Create an Outbound Digital Rule Set

Requires ANY permissions: 

* outbound:digitalRuleSet:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDigitalrulesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new DigitalRuleSet(); // DigitalRuleSet | Digital Rule Set

            try
            { 
                // Create an Outbound Digital Rule Set
                DigitalRuleSet result = apiInstance.PostOutboundDigitalrulesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDigitalrulesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DigitalRuleSet**](DigitalRuleSet.html)| Digital Rule Set |  |
{: class="table table-striped"}

### Return type

[**DigitalRuleSet**](DigitalRuleSet.html)

<a name="postoutbounddnclistemailaddresses"></a>

## void PostOutboundDnclistEmailaddresses (string dncListId, List<string> body)



Add email addresses to a DNC list.

Only Internal DNC lists may be appended to

Requires ANY permissions: 

* outbound:dnc:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistEmailaddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new List<string>(); // List<string> | DNC email addresses

            try
            { 
                // Add email addresses to a DNC list.
                apiInstance.PostOutboundDnclistEmailaddresses(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclistEmailaddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**List<string>**](string.html)| DNC email addresses |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postoutbounddnclistexport"></a>

## [**DomainEntityRef**](DomainEntityRef.html) PostOutboundDnclistExport (string dncListId)



Initiate the export of a dnc list.

Returns 200 if received OK.

Requires ALL permissions: 

* outbound:dnc:view
* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            { 
                // Initiate the export of a dnc list.
                DomainEntityRef result = apiInstance.PostOutboundDnclistExport(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclistExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

[**DomainEntityRef**](DomainEntityRef.html)

<a name="postoutbounddnclistphonenumbers"></a>

## void PostOutboundDnclistPhonenumbers (string dncListId, List<string> body, string expirationDateTime = null)



Add phone numbers to a DNC list.

Only Internal DNC lists may be appended to

Requires ANY permissions: 

* outbound:dnc:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistPhonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new List<string>(); // List<string> | DNC Phone Numbers
            var expirationDateTime = expirationDateTime_example;  // string | Expiration date for DNC phone numbers in yyyy-MM-ddTHH:mmZ format (optional) 

            try
            { 
                // Add phone numbers to a DNC list.
                apiInstance.PostOutboundDnclistPhonenumbers(dncListId, body, expirationDateTime);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclistPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**List<string>**](string.html)| DNC Phone Numbers |  |
| **expirationDateTime** | **string**| Expiration date for DNC phone numbers in yyyy-MM-ddTHH:mmZ format | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postoutbounddnclists"></a>

## [**DncList**](DncList.html) PostOutboundDnclists (DncListCreate body)



Create dialer DNC list

Requires ANY permissions: 

* outbound:dncList:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new DncListCreate(); // DncListCreate | DncList

            try
            { 
                // Create dialer DNC list
                DncList result = apiInstance.PostOutboundDnclists(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DncListCreate**](DncListCreate.html)| DncList |  |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="postoutboundfilespecificationtemplates"></a>

## [**FileSpecificationTemplate**](FileSpecificationTemplate.html) PostOutboundFilespecificationtemplates (FileSpecificationTemplate body)



Create File Specification Template

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundFilespecificationtemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new FileSpecificationTemplate(); // FileSpecificationTemplate | FileSpecificationTemplate

            try
            { 
                // Create File Specification Template
                FileSpecificationTemplate result = apiInstance.PostOutboundFilespecificationtemplates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundFilespecificationtemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FileSpecificationTemplate**](FileSpecificationTemplate.html)| FileSpecificationTemplate |  |
{: class="table table-striped"}

### Return type

[**FileSpecificationTemplate**](FileSpecificationTemplate.html)

<a name="postoutboundimporttemplates"></a>

## [**ImportTemplate**](ImportTemplate.html) PostOutboundImporttemplates (ImportTemplate body)



Create Import Template

Requires ANY permissions: 

* outbound:importTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundImporttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ImportTemplate(); // ImportTemplate | ImportTemplate

            try
            { 
                // Create Import Template
                ImportTemplate result = apiInstance.PostOutboundImporttemplates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundImporttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ImportTemplate**](ImportTemplate.html)| ImportTemplate |  |
{: class="table table-striped"}

### Return type

[**ImportTemplate**](ImportTemplate.html)

<a name="postoutboundimporttemplatesbulkadd"></a>

## [**ImportTemplateEntityListing**](ImportTemplateEntityListing.html) PostOutboundImporttemplatesBulkAdd (List<ImportTemplate> body)



Add multiple import templates

Requires ANY permissions: 

* outbound:importTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundImporttemplatesBulkAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new List<ImportTemplate>(); // List<ImportTemplate> | import template(s) to add

            try
            { 
                // Add multiple import templates
                ImportTemplateEntityListing result = apiInstance.PostOutboundImporttemplatesBulkAdd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundImporttemplatesBulkAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<ImportTemplate>**](ImportTemplate.html)| import template(s) to add |  |
{: class="table table-striped"}

### Return type

[**ImportTemplateEntityListing**](ImportTemplateEntityListing.html)

<a name="postoutboundmessagingcampaigns"></a>

## [**MessagingCampaign**](MessagingCampaign.html) PostOutboundMessagingcampaigns (MessagingCampaign body)



Create a Messaging Campaign

Requires ANY permissions: 

* outbound:messagingCampaign:add
* outbound:emailCampaign:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundMessagingcampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new MessagingCampaign(); // MessagingCampaign | Messaging Campaign

            try
            { 
                // Create a Messaging Campaign
                MessagingCampaign result = apiInstance.PostOutboundMessagingcampaigns(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundMessagingcampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MessagingCampaign**](MessagingCampaign.html)| Messaging Campaign |  |
{: class="table table-striped"}

### Return type

[**MessagingCampaign**](MessagingCampaign.html)

<a name="postoutboundmessagingcampaignsprogress"></a>

## [**List&lt;CampaignProgress&gt;**](CampaignProgress.html) PostOutboundMessagingcampaignsProgress (List<string> body)



Get progress for a list of messaging campaigns

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundMessagingcampaignsProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new List<string>(); // List<string> | Messaging Campaign IDs

            try
            { 
                // Get progress for a list of messaging campaigns
                List<CampaignProgress> result = apiInstance.PostOutboundMessagingcampaignsProgress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundMessagingcampaignsProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string.html)| Messaging Campaign IDs |  |
{: class="table table-striped"}

### Return type

[**List<CampaignProgress>**](CampaignProgress.html)

<a name="postoutboundrulesets"></a>

## [**RuleSet**](RuleSet.html) PostOutboundRulesets (RuleSet body)



Create a Rule Set.

Requires ANY permissions: 

* outbound:ruleSet:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundRulesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new RuleSet(); // RuleSet | RuleSet

            try
            { 
                // Create a Rule Set.
                RuleSet result = apiInstance.PostOutboundRulesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundRulesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RuleSet**](RuleSet.html)| RuleSet |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="postoutboundsequences"></a>

## [**CampaignSequence**](CampaignSequence.html) PostOutboundSequences (CampaignSequence body)



Create a new campaign sequence.

Requires ANY permissions: 

* outbound:campaignSequence:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundSequencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new CampaignSequence(); // CampaignSequence | Organization

            try
            { 
                // Create a new campaign sequence.
                CampaignSequence result = apiInstance.PostOutboundSequences(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundSequences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CampaignSequence**](CampaignSequence.html)| Organization |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="putoutboundattemptlimit"></a>

## [**AttemptLimits**](AttemptLimits.html) PutOutboundAttemptlimit (string attemptLimitsId, AttemptLimits body)



Update attempt limits

Requires ANY permissions: 

* outbound:attemptLimits:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundAttemptlimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID
            var body = new AttemptLimits(); // AttemptLimits | AttemptLimits

            try
            { 
                // Update attempt limits
                AttemptLimits result = apiInstance.PutOutboundAttemptlimit(attemptLimitsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |
| **body** | [**AttemptLimits**](AttemptLimits.html)| AttemptLimits |  |
{: class="table table-striped"}

### Return type

[**AttemptLimits**](AttemptLimits.html)

<a name="putoutboundcallabletimeset"></a>

## [**CallableTimeSet**](CallableTimeSet.html) PutOutboundCallabletimeset (string callableTimeSetId, CallableTimeSet body)



Update callable time set

Requires ANY permissions: 

* outbound:callableTimeSet:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCallabletimesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet

            try
            { 
                // Update callable time set
                CallableTimeSet result = apiInstance.PutOutboundCallabletimeset(callableTimeSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
| **body** | [**CallableTimeSet**](CallableTimeSet.html)| DialerCallableTimeSet |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="putoutboundcallanalysisresponseset"></a>

## [**ResponseSet**](ResponseSet.html) PutOutboundCallanalysisresponseset (string callAnalysisSetId, ResponseSet body)



Update a dialer call analysis response set.

Requires ANY permissions: 

* outbound:responseSet:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCallanalysisresponsesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID
            var body = new ResponseSet(); // ResponseSet | ResponseSet

            try
            { 
                // Update a dialer call analysis response set.
                ResponseSet result = apiInstance.PutOutboundCallanalysisresponseset(callAnalysisSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
| **body** | [**ResponseSet**](ResponseSet.html)| ResponseSet |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="putoutboundcampaign"></a>

## [**Campaign**](Campaign.html) PutOutboundCampaign (string campaignId, Campaign body)



Update a campaign.

Requires ALL permissions: 

* outbound:campaign:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new Campaign(); // Campaign | Campaign

            try
            { 
                // Update a campaign.
                Campaign result = apiInstance.PutOutboundCampaign(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**Campaign**](Campaign.html)| Campaign |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="putoutboundcampaignagent"></a>

## **string** PutOutboundCampaignAgent (string campaignId, string userId, Agent body)



Send notification that an agent's state changed 

New agent state.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignAgentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var userId = userId_example;  // string | Agent's user ID
            var body = new Agent(); // Agent | agent

            try
            { 
                // Send notification that an agent's state changed 
                string result = apiInstance.PutOutboundCampaignAgent(campaignId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaignAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **userId** | **string**| Agent&#39;s user ID |  |
| **body** | [**Agent**](Agent.html)| agent |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putoutboundcampaignrule"></a>

## [**CampaignRule**](CampaignRule.html) PutOutboundCampaignrule (string campaignRuleId, CampaignRule body)



Update Campaign Rule

Requires ANY permissions: 

* outbound:campaignRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID
            var body = new CampaignRule(); // CampaignRule | CampaignRule

            try
            { 
                // Update Campaign Rule
                CampaignRule result = apiInstance.PutOutboundCampaignrule(campaignRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |
| **body** | [**CampaignRule**](CampaignRule.html)| CampaignRule |  |
{: class="table table-striped"}

### Return type

[**CampaignRule**](CampaignRule.html)

<a name="putoutboundcontactlist"></a>

## [**ContactList**](ContactList.html) PutOutboundContactlist (string contactListId, ContactList body)



Update a contact list.

Requires ANY permissions: 

* outbound:contactList:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var body = new ContactList(); // ContactList | ContactList

            try
            { 
                // Update a contact list.
                ContactList result = apiInstance.PutOutboundContactlist(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **body** | [**ContactList**](ContactList.html)| ContactList |  |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="putoutboundcontactlistcontact"></a>

## [**DialerContact**](DialerContact.html) PutOutboundContactlistContact (string contactListId, string contactId, DialerContact body)



Update a contact.

Requires ANY permissions: 

* outbound:contact:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID
            var body = new DialerContact(); // DialerContact | Contact

            try
            { 
                // Update a contact.
                DialerContact result = apiInstance.PutOutboundContactlistContact(contactListId, contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
| **body** | [**DialerContact**](DialerContact.html)| Contact |  |
{: class="table table-striped"}

### Return type

[**DialerContact**](DialerContact.html)

<a name="putoutboundcontactlistfilter"></a>

## [**ContactListFilter**](ContactListFilter.html) PutOutboundContactlistfilter (string contactListFilterId, ContactListFilter body)



Update Contact List Filter

Requires ANY permissions: 

* outbound:contactListFilter:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistfilterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter

            try
            { 
                // Update Contact List Filter
                ContactListFilter result = apiInstance.PutOutboundContactlistfilter(contactListFilterId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |
| **body** | [**ContactListFilter**](ContactListFilter.html)| ContactListFilter |  |
{: class="table table-striped"}

### Return type

[**ContactListFilter**](ContactListFilter.html)

<a name="putoutboundcontactlisttemplate"></a>

## [**ContactListTemplate**](ContactListTemplate.html) PutOutboundContactlisttemplate (string contactListTemplateId, ContactListTemplate body)



Update a contact list template.

Requires ANY permissions: 

* outbound:contactListTemplate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlisttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListTemplateId = contactListTemplateId_example;  // string | ContactListTemplate ID
            var body = new ContactListTemplate(); // ContactListTemplate | ContactListTemplate

            try
            { 
                // Update a contact list template.
                ContactListTemplate result = apiInstance.PutOutboundContactlisttemplate(contactListTemplateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlisttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListTemplateId** | **string**| ContactListTemplate ID |  |
| **body** | [**ContactListTemplate**](ContactListTemplate.html)| ContactListTemplate |  |
{: class="table table-striped"}

### Return type

[**ContactListTemplate**](ContactListTemplate.html)

<a name="putoutbounddigitalruleset"></a>

## [**DigitalRuleSet**](DigitalRuleSet.html) PutOutboundDigitalruleset (string digitalRuleSetId, DigitalRuleSet body)



Update an Outbound Digital Rule Set

Requires ANY permissions: 

* outbound:digitalRuleSet:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundDigitalrulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var digitalRuleSetId = digitalRuleSetId_example;  // string | The Digital Rule Set ID
            var body = new DigitalRuleSet(); // DigitalRuleSet | Digital Rule Set

            try
            { 
                // Update an Outbound Digital Rule Set
                DigitalRuleSet result = apiInstance.PutOutboundDigitalruleset(digitalRuleSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundDigitalruleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **digitalRuleSetId** | **string**| The Digital Rule Set ID |  |
| **body** | [**DigitalRuleSet**](DigitalRuleSet.html)| Digital Rule Set |  |
{: class="table table-striped"}

### Return type

[**DigitalRuleSet**](DigitalRuleSet.html)

<a name="putoutbounddnclist"></a>

## [**DncList**](DncList.html) PutOutboundDnclist (string dncListId, DncList body)



Update dialer DNC list

Requires ANY permissions: 

* outbound:dncList:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundDnclistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncList(); // DncList | DncList

            try
            { 
                // Update dialer DNC list
                DncList result = apiInstance.PutOutboundDnclist(dncListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundDnclist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncList**](DncList.html)| DncList |  |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="putoutboundfilespecificationtemplate"></a>

## [**FileSpecificationTemplate**](FileSpecificationTemplate.html) PutOutboundFilespecificationtemplate (string fileSpecificationTemplateId, FileSpecificationTemplate body)



Update File Specification Template

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundFilespecificationtemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var fileSpecificationTemplateId = fileSpecificationTemplateId_example;  // string | File Specification Template ID
            var body = new FileSpecificationTemplate(); // FileSpecificationTemplate | fileSpecificationTemplate

            try
            { 
                // Update File Specification Template
                FileSpecificationTemplate result = apiInstance.PutOutboundFilespecificationtemplate(fileSpecificationTemplateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundFilespecificationtemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **fileSpecificationTemplateId** | **string**| File Specification Template ID |  |
| **body** | [**FileSpecificationTemplate**](FileSpecificationTemplate.html)| fileSpecificationTemplate |  |
{: class="table table-striped"}

### Return type

[**FileSpecificationTemplate**](FileSpecificationTemplate.html)

<a name="putoutboundimporttemplate"></a>

## [**ImportTemplate**](ImportTemplate.html) PutOutboundImporttemplate (string importTemplateId, ImportTemplate body)



Update Import Template

Requires ANY permissions: 

* outbound:importTemplate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundImporttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var importTemplateId = importTemplateId_example;  // string | Import Template ID
            var body = new ImportTemplate(); // ImportTemplate | importTemplate

            try
            { 
                // Update Import Template
                ImportTemplate result = apiInstance.PutOutboundImporttemplate(importTemplateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundImporttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importTemplateId** | **string**| Import Template ID |  |
| **body** | [**ImportTemplate**](ImportTemplate.html)| importTemplate |  |
{: class="table table-striped"}

### Return type

[**ImportTemplate**](ImportTemplate.html)

<a name="putoutboundmessagingcampaign"></a>

## [**MessagingCampaign**](MessagingCampaign.html) PutOutboundMessagingcampaign (string messagingCampaignId, MessagingCampaign body)



Update an Outbound Messaging Campaign

Requires ANY permissions: 

* outbound:messagingCampaign:edit
* outbound:emailCampaign:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID
            var body = new MessagingCampaign(); // MessagingCampaign | MessagingCampaign

            try
            { 
                // Update an Outbound Messaging Campaign
                MessagingCampaign result = apiInstance.PutOutboundMessagingcampaign(messagingCampaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |
| **body** | [**MessagingCampaign**](MessagingCampaign.html)| MessagingCampaign |  |
{: class="table table-striped"}

### Return type

[**MessagingCampaign**](MessagingCampaign.html)

<a name="putoutboundruleset"></a>

## [**RuleSet**](RuleSet.html) PutOutboundRuleset (string ruleSetId, RuleSet body)



Update a Rule Set.

Requires ANY permissions: 

* outbound:ruleSet:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundRulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID
            var body = new RuleSet(); // RuleSet | RuleSet

            try
            { 
                // Update a Rule Set.
                RuleSet result = apiInstance.PutOutboundRuleset(ruleSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundRuleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
| **body** | [**RuleSet**](RuleSet.html)| RuleSet |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="putoutboundschedulescampaign"></a>

## [**CampaignSchedule**](CampaignSchedule.html) PutOutboundSchedulesCampaign (string campaignId, CampaignSchedule body)



Update a new campaign schedule.

Requires ANY permissions: 

* outbound:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new CampaignSchedule(); // CampaignSchedule | CampaignSchedule

            try
            { 
                // Update a new campaign schedule.
                CampaignSchedule result = apiInstance.PutOutboundSchedulesCampaign(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**CampaignSchedule**](CampaignSchedule.html)| CampaignSchedule |  |
{: class="table table-striped"}

### Return type

[**CampaignSchedule**](CampaignSchedule.html)

<a name="putoutboundschedulesemailcampaign"></a>

## [**EmailCampaignSchedule**](EmailCampaignSchedule.html) PutOutboundSchedulesEmailcampaign (string emailCampaignId, EmailCampaignSchedule body)



Update an email campaign schedule.

Requires ANY permissions: 

* outbound:emailCampaignSchedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesEmailcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var emailCampaignId = emailCampaignId_example;  // string | Email Campaign ID
            var body = new EmailCampaignSchedule(); // EmailCampaignSchedule | EmailCampaignSchedule

            try
            { 
                // Update an email campaign schedule.
                EmailCampaignSchedule result = apiInstance.PutOutboundSchedulesEmailcampaign(emailCampaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesEmailcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailCampaignId** | **string**| Email Campaign ID |  |
| **body** | [**EmailCampaignSchedule**](EmailCampaignSchedule.html)| EmailCampaignSchedule |  |
{: class="table table-striped"}

### Return type

[**EmailCampaignSchedule**](EmailCampaignSchedule.html)

<a name="putoutboundschedulesmessagingcampaign"></a>

## [**MessagingCampaignSchedule**](MessagingCampaignSchedule.html) PutOutboundSchedulesMessagingcampaign (string messagingCampaignId, MessagingCampaignSchedule body)



Update a new messaging campaign schedule.

Requires ANY permissions: 

* outbound:messagingCampaignSchedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | Messaging Campaign ID
            var body = new MessagingCampaignSchedule(); // MessagingCampaignSchedule | MessagingCampaignSchedule

            try
            { 
                // Update a new messaging campaign schedule.
                MessagingCampaignSchedule result = apiInstance.PutOutboundSchedulesMessagingcampaign(messagingCampaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| Messaging Campaign ID |  |
| **body** | [**MessagingCampaignSchedule**](MessagingCampaignSchedule.html)| MessagingCampaignSchedule |  |
{: class="table table-striped"}

### Return type

[**MessagingCampaignSchedule**](MessagingCampaignSchedule.html)

<a name="putoutboundschedulessequence"></a>

## [**SequenceSchedule**](SequenceSchedule.html) PutOutboundSchedulesSequence (string sequenceId, SequenceSchedule body)



Update a new sequence schedule.

Requires ANY permissions: 

* outbound:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID
            var body = new SequenceSchedule(); // SequenceSchedule | SequenceSchedule

            try
            { 
                // Update a new sequence schedule.
                SequenceSchedule result = apiInstance.PutOutboundSchedulesSequence(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
| **body** | [**SequenceSchedule**](SequenceSchedule.html)| SequenceSchedule |  |
{: class="table table-striped"}

### Return type

[**SequenceSchedule**](SequenceSchedule.html)

<a name="putoutboundsequence"></a>

## [**CampaignSequence**](CampaignSequence.html) PutOutboundSequence (string sequenceId, CampaignSequence body)



Update a new campaign sequence.

Requires ANY permissions: 

* outbound:campaignSequence:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID
            var body = new CampaignSequence(); // CampaignSequence | Organization

            try
            { 
                // Update a new campaign sequence.
                CampaignSequence result = apiInstance.PutOutboundSequence(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
| **body** | [**CampaignSequence**](CampaignSequence.html)| Organization |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="putoutboundwrapupcodemappings"></a>

## [**WrapUpCodeMapping**](WrapUpCodeMapping.html) PutOutboundWrapupcodemappings (WrapUpCodeMapping body)



Update the Dialer wrap up code mapping.

Requires ANY permissions: 

* outbound:wrapUpCodeMapping:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundWrapupcodemappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new WrapUpCodeMapping(); // WrapUpCodeMapping | wrapUpCodeMapping

            try
            { 
                // Update the Dialer wrap up code mapping.
                WrapUpCodeMapping result = apiInstance.PutOutboundWrapupcodemappings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundWrapupcodemappings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapUpCodeMapping**](WrapUpCodeMapping.html)| wrapUpCodeMapping |  |
{: class="table table-striped"}

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping.html)

