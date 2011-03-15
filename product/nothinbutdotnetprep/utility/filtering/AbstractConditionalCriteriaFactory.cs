namespace nothinbutdotnetprep.utility.filtering
{
    public static class AbstractConditionalCriteriaFactory<ItemToMatch>
    {
        public static ConditionalCriteria<ItemToMatch> ConditionalCriteria<ItemToMatch>(MatchingCondition<ItemToMatch> condition)
        {
            return new ConditionalCriteria<ItemToMatch>(condition);
        }
               
    }
}