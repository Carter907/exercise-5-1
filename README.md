```
BEGIN
	CLASS Program
		Main METHOD

			PRINT
			 - "salesperson: "
			VAR salesperson = TO LOWER CASE(PROMPT USER("salesperson: "))
			VAR highestSale = 0
			VAR highest = ""
			VAR grandTotal = 0
			WHILE salesperson != "Z" THEN
				WHEN salesperson EQUALS
					CASE "d" or "e" or "f":
					  VAR sale = CONVERT TO INT (PROMPT USER("sale: "))
					  grandTotal += sale
					  IF sale > highestSale THEN
					    highest = salesperson
					    highestSale = sale
					  BREAK
					  DEFAULT:
					    PRINT
						- "intermediate output: Error, invalid salesperson selected, please try again"
					    BREAK
				      
				      salesperson = LOWER CASE ("salesperson: ")
				    
		        PRINT FORMAT
			   - "Grand Total: {CURRENCY FORMAT: grandTotal}"
		        PRINT
			   - "Highest Sale: {TO UPPER CASE (highest)}"		
		END Main
	END Program
END
```
