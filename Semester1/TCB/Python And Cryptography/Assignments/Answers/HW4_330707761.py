# ------------------------------------------------
# Name: Guy Shitrit
# ID: 330707761
# ------------------------------------------------

from random import randrange
from time import sleep

SLEEP_TIME = 0.1
SETS = 3

# player_structure: Full Name | Birth Date | Total Matches | Total Points
# מעקב עבור המידע הנכון בעזרת קבועים ששומרים אינדקסים
NAME = 0
DATE = 1
MATCHES = 2
POINTS = 3

players = [['Novak Djokovic', '22/05/1987', 30, 1150],
           ['Daniil Medvedev', '11/02/1996', 16, 870],
           ['Alexander Zverev', '20/04/1997', 18, 780],
           ['Stefanos Tsitsipas', '12/08/1998', 17, 650],
           ['Andrey Rublev', '20/10/1997', 20, 520],
           ['Rafael Nadal', '03/06/1986', 17, 490],
           ['Matteo Berrettini', '12/03/1996', 12, 460],
           ['Casper Ruud', '22/12/1998', 10, 420],
           ['Hubert Hurkacz', '11/02/1997', 10, 370],
           ['Jannik Sinner', '16/08/2001', 14, 340],
           ['Félix Auger-Aliassime', '08/08/2000', 11, 330],
           ['Cameron Norrie', '23/08/1995', 10, 300],
           ['Diego Schwartzman', '16/08/1992', 20, 260],
           ['Denis Shapovalov', '15/03/1999', 15, 250],
           ['Dominic Thiem', '03/09/1996', 14, 240],
           ['Roger Federer', '08/08/1981', 27, 230]]


def doMatch(player1, player2):
    p1_sets = 0
    p2_sets = 0

    for curr_set in range(SETS):
        p1_wins = 0
        p2_wins = 0

        if p1_sets == 2 or p2_sets == 2:
            break

        while (p1_wins != 7 or p2_wins != 7) or (p1_wins == 6 and p1_wins >= p2_wins + 2) or (p2_wins == 6 and p2_wins >= p1_wins + 2):
            curr = randrange(0,2) # אחד או אפס
            p1_wins += curr
            p2_wins += (1 - curr)


def doTournament(tname, plist, pamount):
    def choicePlayers():
        pass

    pass


def printPlayer(player):
    print("-\t" * 8)
    print(f"Full Name: {player[NAME]}\nDate: {player[DATE]}\nMatches Played: {player[MATCHES]}\nTotal Points: {player[POINTS]}")


def printPlayers(plist, num=0):
    # 0 for all, positive for start->end, negative for end->start
    n = len(plist)

    if num == 0: # אם המספר הוא 0 תדפיס את כל השחקנים
        for player in plist:
            printPlayer(player)

    elif num > 0 and num < n: # אם המספר חיובי (ולא חורג מגודל המערך) תדפיס את השחקנים מההתחלה בהתאם למספר
        for i in range(num):
            printPlayer(plist[i])
    elif num < 0 and abs(num) < n: # אם המספר שלילי (ולא חורג מגודל המערך) תדפיס את השחקנים מהסוף בהתאם למספר
        for i in range(n - 1, n - 1 - abs(num), -1):
            printPlayer(plist[i])

    print("-\t" * 8)


def sortPlayers(plist, field='point', flag=True):
    if field == 'name':
        index = NAME
    elif field == 'date':
        index = DATE
    elif field == 'matches':
        index = MATCHES
    elif field == 'point':
        index = POINTS
    else:
        print("Enter a valid field.")
        return plist # יחזיר את אותו מערך שנשלח

    plist.sort(key = lambda x: x[index], reverse = flag)
    return plist # יחזיר את המערך לאחר מיון אם השדה שנשלח תקין

def addPlayer(plist):
    name = input("Enter full name: ")
    birth_date = input("Enter date of birth: ")
    total_matches = int(input("Enter the amount of total matches: "))
    total_points = int(input("Enter the amount of total points: "))

    player = [name, birth_date, total_matches, total_points]
    plist.append(player)


def removePlayer(plist):
    minn = plist[0][POINTS]
    index = 0

    for i in range(len(plist)):
        if minn > plist[i][POINTS]:
            minn = plist[i][POINTS]
            index = i

    plist.pop(index)


def menu(plist):
    print("#" * 10 + "  MENU  " + "#" * 10)
    print("1) Match\n2) Tournament\n3) Print Players\n4) Sort Players\n5) Add Player\n6) Remove Player")
    print("#" * 28)

    choice = -1

    while not (1 <= choice <= 6):
        choice = int(input("Enter choice: "))

    if choice == 1:
        doMatch()
    elif choice == 2:
        doTournament()
    elif choice == 3:
        printPlayers(players)
    elif choice == 4:
        sortPlayers(players, 'point', False)
    elif choice == 5:
        addPlayer(players)
    elif choice == 6:
        removePlayer(players)
    else:
        print("Have a good day!")
        return

    menu(players)

menu([])

def main():
    pass
    # print('<Print list players>')
    # printPlayers(players)
    # print('\n<Print list players>')
    # printPlayers(players, 4)
    # print('\n<Print list players>')
    # printPlayers(players, -3)
    #
    # print('--------------------------------------------')
    # print('\n<Print Sort list players>')
    # printPlayers(sortPlayers(players, flag=False), 6)
    # print('\n<Print Sort list players>')
    # printPlayers(sortPlayers(players, field='point', flag=False), -5)
    # print('\n<Print Sort list players>')
    # printPlayers(sortPlayers(players, field='name', flag=False), 10)
    # print('\n<Print Sort list players>')
    # printPlayers(sortPlayers(players, field='match', flag=True), 10)
    # print('\n<Print Sort list players>')
    # printPlayers(sortPlayers(players, field='born', flag=False), 6)
    #
    # print('--------------------------------------------')
    # print('<Add player>')
    # addPlayer(players)
    # print('\n<Print list players>')
    # printPlayers(players)
    #
    # print('--------------------------------------------')
    # print('<Remove player>')
    # removePlayer(players)
    # print('\n<Print list players>')
    # printPlayers(players)
    #
    # print('--------------------------------------------')
    # print('<Tournamen>')
    # doTournament('Wimbledon', players, 4)
    # print('\n<Print list players>')
    # printPlayers(sortPlayers(players, field='point', flag=True))


main()
