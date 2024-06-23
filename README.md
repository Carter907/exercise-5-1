```
BEGIN
	CLASS Program
		Main METHOD
			VAR allowedInitials = CHAR ARRAY OF { 'd', 'e', 'f' }
			VAR salesPeople = CHAR ARRAY[SIZE: 3]
			VAR peopleIndex = 0
			VAR accumulatedSales = INT ARRAY[SIZE: 3]
			VAR salesIndex = 0
			
			VAR salesperson = TO LOWER CASE(PROMPT USER("salesperson: "))
			VAR highestSale = 0
			VAR highest = ''
			VAR grandTotal = 0
			
			WHILE salesperson not equal 'z' THEN
			
				VAR isPersonAllowed = false;
				FOREACH VAR allowedInitial in allowedInitials
				
					
					IF salesperson equals allowedInitial THEN
					
					  isPersonAllowed = true;
					  VAR sale = CONVERT TO INT (PROMPT USER("sale: "))
					  accumulatedSales AT INDEX [salesIndex] = sale;
					  salesPeople AT INDEX [peopleIndex] = salesperson; 
					  grandTotal += sale;
					  IF sale > highestSale THEN
					  
					    highest = salesperson;
					    highestSale = sale;
					  
					
				
				IF isPersonAllowed THEN

					PRINT
						- "intermediate output: Error, invalid salesperson selected, please try again"

				

				
				VAR salesperson = TO LOWER CASE(PROMPT USER("salesperson: "))
				salesIndex++;
				peopleIndex++;
			}
				    
		        PRINT FORMAT
			   - "Grand Total: {CURRENCY FORMAT: grandTotal}"
		        PRINT
			   - "Highest Sale: {TO UPPER CASE (highest)}"		
		END Main
	END Program
END
```
