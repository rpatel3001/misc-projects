import sys,tty,termios

def main(size,winlen):
    #initialize
    print("\033[?25l\033[1m\033[40m")
    player = YELLOW
    board = generateBoard(size)
    #game loop
    while 1:
        pos=0
        while 1:
            printBoard(board, pos, player)
            k=getch().upper()
            if k == 'A':
                pos=(pos-1)%size[1]
            elif k == 'D':
                pos=(pos+1)%size[1]
            elif k == 'S' and drop(player,pos,board):
                break

        printBoard(board, pos, player)
        testWin(player,board,winlen)

        if player==YELLOW:
            player=RED
        else:
            player=YELLOW

def testWin(player, board, winlen):
    for x in range(len(board)):
        for y in range(len(board[0])-winlen):
            win = True
            for i in range(0, winlen):
                if board[x][y+i] != player:
                    win = False
                    break
            if win:
               finish(player)

    for x in range(len(board[0])):
        for y in range(winlen-1, len(board)):
            win = True
            for i in range(0, winlen):
                if board[y-i][x] != player:
                    win = False
                    break
            if win:
               finish(player)

    for x in range(winlen - 1, len(board)):
    	for y in range(winlen - 1, len(board[0])):
    		win = True
    		for i in range(winlen):
    			if player != board[x-i][y-i]:
    				win = False
    				break
    		if win:
    			finish(player)

    for x in range(winlen - 1, len(board)):
    	for y in range(len(board[0]) - winlen + 1):
    		win = True
    		for i in range(winlen):
    			if player != board[x-i][y+i]:
    				win = False
    				break
    		if win:
    			finish(player)

    draw=True
    for x in board[0]:
        if x == EMPTY:
            draw = False
            break
    if draw:
        finish(EMPTY)

def drop(player,pos,board):
    x=0
    while 1:
        if board[x][pos]!=EMPTY:
            if x == 0:
                return False
            else:
                board[x-1][pos]=player
                return True
        elif x == len(board)-1:
            board[x][pos] = player
            return True
        else:
            x+=1

def generateBoard(size):
    return [[EMPTY for y in range(size[1])] for x in range(size[0])]

def printBoard(board, pos, player):
    print("\x1b[2J\x1b[H",end='')
    print("  " * pos + player)
    print('\033[44m',end='')
    for row in board:
        for cell in row:
            print('\033[44m'+str(cell),end='')
        print("\n\033[40m",end='')
    print('\010',end='')

CIRCLE='\u25cf \033[40m'
EMPTY='\033[37m' + CIRCLE
YELLOW='\033[33m' + CIRCLE
RED='\033[31m' + CIRCLE

def getch():
    fd = sys.stdin.fileno()
    old_settings = termios.tcgetattr(fd)
    try:
        tty.setraw(sys.stdin.fileno())
        ch = sys.stdin.read(1)
    finally:
        termios.tcsetattr(fd, termios.TCSADRAIN, old_settings)
    if ord(ch)==3:
        finish(None)
    return ch

def finish(player):
    #print("\033[37m\x1b[2J\x1b[H\033[?25h")
    if player == EMPTY:
        print("It's a draw")
    elif player is not None:
        print(player + " wins!")
    exit()

if __name__ == '__main__':
    s=(6,7)
    winlen=4
    try:
        s=(int(sys.argv[2]), int(sys.argv[1]))
        winlen = int(sys.argv[3])
    except:
        pass
    main(s,winlen)
