# legendary-octo-parakeet
List-Optimized Random Number Generator

Ever get tired of picking a random number for a raffle over Google Docs? Fear not!

This program will effectively open a specified text file, grab all of its contents, and find the optimal random number that you should pick to maximize your chances of winning a raffle.

As such, a valid "Google Docs raffle" is specified as follows:
 - One where every candidate's selected number is readily available in a column.
 - One where you can copy a data column from a spreadsheet service (Google Docs, Excel, etc.)
 
To functionally run this program, copy the desired column of data you're looking for and paste it into "in.txt" in bin/debug.
In essence, the program will sort all entries, and calculate the largest gap in the data. This is accomplished by iterating through the list of entries and finding the largest distance between two integers. 
Theoretically, you'll want to pick the average of these two numbers to cover the biggest range of possible entries to maximize your probability of winning. By finding the largest range of data that you can pick from, we can game the system to mathematically cover a significantly larger range of possible winning numbers rather than merely selecting a random one.

Granted, this code is garbage and requires mending.
Cheers.
