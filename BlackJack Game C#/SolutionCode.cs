using System.IO;
using System;
namespace blacljack
{
class Program
 {
    static void Main(string[] args)
    {
        int playerCardValue = 0;
        int dealerCardValue = 0;
        
        Random random = new Random();
        
        playerCardValue += random.Next(1,12);
        playerCardValue += random.Next(1,12);
        
        if (playerCardValue > 21)
        {
            playerCardValue -= 10;
        }
        dealerCardValue += random.Next(1,12);
        dealerCardValue += random.Next(1,12);
        
        if (dealerCardValue > 21)
        {
            dealerCardValue -= 10;
        }
        //player turn
        while(true)
        {
            if(playerCardValue == 21)
            {
                Console.WriteLine("Hurrah 🎉!");
                break;
            }
            Console.WriteLine("My Card Value: " + playerCardValue.ToString() + "Hit?");
            
            string answer = Console.ReadLine();
            
            if (answer == "yes")
            {
                playerCardValue += random.Next(1,12);
                
                if (playerCardValue > 21)
                {
                    Console.WriteLine("You Busted!!");
                    break;
                }
                
                else
                {
                    continue;
                }
            }
            else if (answer == "No")
            {
                break;
            }
            
            else
            {
                Console.WriteLine("incorrect response, try again");
                continue;
            }
        }
        //dealer turn
        Console.WriteLine("player card value is " + playerCardValue.ToString());
        
        if (playerCardValue <= 21)
        {
            while (dealerCardValue < 21 && dealerCardValue < playerCardValue)
            {
                dealerCardValue += random.Next(1,12);
            }
            
            if (playerCardValue == dealerCardValue)
            {
                 Console.WriteLine("player and dealer have tied");
            }
            else if(playerCardValue < dealerCardValue && dealerCardValue <= 21)
            {
             Console.WriteLine("dealer has won");
            }
            else if(dealerCardValue > 21)
            {
              Console.WriteLine("dealer has busted, player has won!");
            }
            else if(dealerCardValue == 21)
            {
                Console.WriteLine("Dealer has won!");
            }
    } 
    
    else
    {
        Console.WriteLine("dealer has won, player has busted");
    }
    Console.WriteLine("Dealers Value: " + dealerCardValue.ToString());
    Console.ReadLine();
    }
 }
 
}
