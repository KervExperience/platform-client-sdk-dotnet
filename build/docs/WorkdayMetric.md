---
title: WorkdayMetric
---
## ININ.PureCloudApi.Model.WorkdayMetric

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metric** | [**Metric**](Metric.html) | Gamification metric | [optional] |
| **Objective** | [**Objective**](Objective.html) | Current objective for this metric | [optional] |
| **Points** | **int?** | Gamification points earned for this metric | [optional] |
| **MaxPoints** | **int?** | The maximum Gamification points a user may earn for this metric | [optional] |
| **Value** | **double?** | Value of this metric | [optional] |
| **PunctualityEvents** | [**List&lt;PunctualityEvent&gt;**](PunctualityEvent.html) | List of schedule activity events for punctuality metrics | [optional] |
| **EvaluationDetails** | [**List&lt;QualityEvaluationScoreItem&gt;**](QualityEvaluationScoreItem.html) | List of evaluations for quality evaluation score metrics | [optional] |
{: class="table table-striped"}


