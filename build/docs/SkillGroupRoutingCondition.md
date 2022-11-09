---
title: SkillGroupRoutingCondition
---
## ININ.PureCloudApi.Model.SkillGroupRoutingCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RoutingSkill** | **string** | The routing skill to be used in the skill condition query | |
| **Comparator** | **string** | Comparator that will be applied to the proficiency | |
| **Proficiency** | **int?** | The skill proficiency that will be used for the routing skill. Integer range 0-5 | |
| **ChildConditions** | [**List&lt;SkillGroupCondition&gt;**](SkillGroupCondition.html) | Nested conditions to be applied to this skill condition | [optional] |
{: class="table table-striped"}


