# PromotionEngineAPI
Implementation of a simple promotion engine for a checkout process.
Promotion Engine is caculating following Active Promotions
Active Promotions
3 of A's for 130
2 of B's for 45
C & D for 30

And following is the Unit Prices of each Prodcuts:
Unit price for SKU IDs
A 50
B 30
C 20
D 15

Scenario A
1* A  50
1* B  30
1* C  20
Total 100

Scenario B
5 * A 130 + 2*50
5 * B 45 + 45 + 30
1 * C 28
Total 370

Scenario C
3* A 130
5* B 45 + 45 + 1 * 30
1 * C  -  
1* D   30
Total 280


Sample Request :- 
{
	"ItemA":  5,
	"ItemB": 	5,
	"ItemC": 	1,	
	"ItemD": 	0
}

Sample Response :- 
{
   "TotalAmount": 370,
   "ResponseMetaData":    {
      "Status": "S",
      "Message": null
   }
}
