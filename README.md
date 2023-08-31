 
======================================
Gilded Rose Requirements Specification
======================================

Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a
prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods.
Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We
have a system in place that updates our inventory for us. It was developed by a no-nonsense type named
Leeroy, who has moved on to new adventures. Your task is to add the new feature to our system so that
we can begin selling a new category of items. First an introduction to our system:

	- All items have a SellIn value which denotes the number of days we have to sell the item
	- All items have a Quality value which denotes how valuable the item is
	- At the end of each day our system lowers both values for every item

Pretty simple, right? Well this is where it gets interesting:

	- Once the sell by date has passed, Quality degrades twice as fast
	- The Quality of an item is never negative
	- "Aged Brie" actually increases in Quality the older it gets
	- The Quality of an item is never more than 50
	- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
	- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
	Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
	Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

	- "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything
still works correctly. However, do not alter the Item class or Items property as those belong to the
goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code
ownership (you can make the UpdateQuality method and Items property static if you like, we'll cover
for you).

Just for clarification, an item can never have its Quality increase above 50, however "Sulfuras" is a
legendary item and as such its Quality is 80 and it never alters.

---------------------------------------------------------- Steps To Run the Application : Start  ----------------------------------------------------------

---------------------------------------------------------- Steps To Run the Application : End  ------------------------------------------------------------

---------------------------------------------------------- Solution And Approach Explanation : Start -------------------------------------------------------

There are several types of goods based on the requirements, and each good has its own set of rules that affect its quality and value.
Goods divided the goods into the following categories.
 
* AgedBrieRule - This class would be in responsible for applying the rules for the "AgedBrie" items.
* BackstagePassRule - This class would be in responsible for applying the rules for the "BackstagePass" items.
* ConjuredRule - This class would be in responsible for applying the rules for the "Conjured" items.
* SulfurasHandRagnarosRule - This class would be in responsible for applying the rules for the "SulfurasHandRagnaros" items.
* OtherGoodRule  - This class would be in responsible for applying the rules for the rest of items.

This is an abstract class "UniversalRule" responsible for applying the unversal rules mentioned below. 
Any item specific class need to inherit just the UniversalRule abstract class. This would give the UniversalRuleApply method for all the universal rules. We have implemented this way in class AgedBrieRule.
Any item specific class need to inherit just the UniversalRule abstract classs and need to impelement some item specific rules then this class need to implemen the UniversalRuleApply and method for item specifc rules. We have this implemented in BackstagePass item.

The Quality of an item is never more than 50
The Quality of an item is never negative
Once the sell by date has passed, Quality degrades twice as fast
At the end of each day our system lowers both values for every item

----------- Aged Brie : Item specific Rules-----------------------------
This items implemented the UniversalRuleApply because below rules already covered in Universal rules.
"Aged Brie" actually increases in Quality the older it gets
 this.UniversalRuleApply(item);

----------- BackstagePass : Item specific Rules-----------------------------
This items implemented the below rules along with the UniversalRuleApply.
"Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
Quality drops to 0 after the concert. [ this.BackstagePassRuleApply(item);]
this.UniversalRuleApply(item);
 
----------- Conjured : Item specific Rules-----------------------------
Conjured - These items will implement the below rule along with the UniversalRuleApply.
"Conjured" items degrade in Quality twice as fast as normal items. [ this.ConjuredRuleApply(item);]
this.UniversalRuleApply(item);

----------- SulfurasHandRagnaros : Item specific Rules-----------------------------
SulfurasHandRagnaros - We do not need to apply any rules based on the required description. These records should be unchanged.
"Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.


----------- Other Items : UniversalRule Rules-----------------------------
OtherGoodRule - Because there are no rules specified in the description for the remaining items, we shall use Universal rules. [this.UniversalRuleApply(item)]


---------------------------------------------------------- Solution And Approach Explanation : End -----------------------------------------------------------------

----------------------------------------------------------- Unit Test Scenarios : Start ----------------------------------------------------------------------------
Universal Rules
	Unit Test1 - EachDaySystemLowersQuealitySellin : At the end of each day our system lowers both values for every item
	Unit Test2 - OnceSellDatePassedQualityDegradesTwiceFast : Once the sell by date has passed, Quality degrades twice as fast
	Unit Test3 - QualityNeverNegative : The Quality of an item is never negative
	Unit Test4 - ItemQualityNeverExceedFifty : Quality of an item is never more than 50
	
Item Specific Rules
	Unit Test5 - SulfurasNeverSoldDecreasesQuality : Sulfuras being a legendary item, never has to be sold or decreases in Quality
	Unit Test6 - QualityIncreasesBy2By10AndLessDays : Quality increases by 2 when there are 10 days or less
	Unit Test7 - QualityIncreasesBy3By10AndLessDays : Quality increases by 3 when there are 5 days or less
	Unit Test8 - QualityDropsToZeroAfterConcert : Quality drops to 0 after the concert.
	Unit Test9 - ConjuredQualityDegradesFast : Conjured items degrade in Quality twice as fast as normal items
 
----------------------------------------------------------- Unit Test Scenarios : End ----------------------------------------------------------------------------
