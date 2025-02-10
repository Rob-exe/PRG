using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime;

Dictionary<string, int> votes = new Dictionary<string, int>();
Random rng = new Random();
int voteNumber = rng.Next(100,2500);
int candidate0, candidate1, candidate2 = 0;
float candPerc0, candPerc1, candPerc2;
int[] votesCast = new int[voteNumber];
for (int i = 0; i < voteNumber; i++)
{
	votesCast = rng.Next(0,2);
}
foreach (var vote in votesCast)
{
	switch (vote)
	{
		case 0:
			candidate0++;
			break;
		case 1:
			candidate1++;
			break;
		case 2:
			candidate2++;
			break;
	}
}
candPerc0 = candidate0*100 /voteNumber;
candPerc1 = candidate1*100 /voteNumber;
candPerc2 = candidate2*100 /voteNumber;
if (candPerc0 > 50) {
	Console.WriteLine("Candidate 1 won with " + candPerc0 + " % of votes (totalling " + candidate0 + " votes)");
} else if (candPerc1 > 50) {
	
}