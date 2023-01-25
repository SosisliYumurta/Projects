# Import required modules
from random import shuffle
import random

# Define a class to create
# all type of cards
class Cards:
	global suites, values
	suites = ['♥', '♦', '♣',  '♠']
	values = ['A', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K']

	def __init__(self):
		pass


# Define a class to categorize each card
class Deck(Cards):
	def __init__(self):
		Cards.__init__(self)
		self.mycardset = []
		for n in suites:
			for c in values:
				self.mycardset.append((c)+n)

	# Method to remove a card from the deck
	'''
	def popCard(self):
		if len(self.mycardset) == 0:
			return "NO CARDS CAN BE POPPED FURTHER"
		else:
			cardpopped = self.mycardset.pop()
			print("Card removed is", cardpopped)
    '''

# Define a class gto shuffle the deck of cards
'''
class ShuffleCards(Deck):

	# Constructor
	def __init__(self):
		Deck.__init__(self)

	# Method to shuffle cards
	def shuffle(self):
		if len(self.mycardset) <52:
			print("cannot shuffle the cards")
		else:
			shuffle(self.mycardset)
			return self.mycardset
    
	# Method to remove a card from the deck
	def popCard(self):
		if len(self.mycardset) == 0:
			return "NO CARDS CAN BE POPPED FURTHER"
		else:
			cardpopped = self.mycardset.pop()
			return (cardpopped)
    
'''
# Driver Code
# Creating objects
objCards = Cards()
objDeck = Deck()

# Player 1
player1Cards = objDeck.mycardset
#print('\n Player 1 Cards: \n', player1Cards)

# Creating object
#objShuffleCards = ShuffleCards()

# Player 2
#player2Cards = objShuffleCards.shuffle()
#print('\n Player 2 Cards: \n', player2Cards)

smallDeck = []
point = 0
for i in range(13):
    k = int(random.random() * 52)
    print(player1Cards[k], end = '  ')
    smallDeck.append(player1Cards[k])
    

for i in smallDeck:
     if i[0] == 'A':
        point = point + 4
     elif i[0] == 'K':
        point = point + 3
     elif i[0] == 'Q':
        point = point + 2
     elif i[0] == 'J':
        point = point + 1     
print(point)     
hearts = 0
diamonds = 0
clubs = 0
spade = 0
for i in smallDeck:
    if i[1] == '♥':
        hearts = hearts + 1
    elif i[1] == '♦':
        diamonds = diamonds + 1
    elif i[1] == '♣':
        clubs = clubs + 1
    else:
         spade = spade + 1

if point >= 13:
    print("Binding...")
    if spade >= 5:
        print("1S")      
    elif hearts >= 5:
        print("1H")
    elif diamonds >= 5: #Whatt we have to do now ♥♥♥♥
        print("1D")
    elif clubs >= 5:
        print("1C") 
    else:
        print("1NT")    
else:
    print("Pas")    


#['♥', '♦', '♣',  '♠']


                    




      




