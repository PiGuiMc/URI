while True:
    custo,auxp,auxs,i = 0,0,0,0
    try:
        n = int(input())

        numPac = [int(n) for n in input().split()]
        numSeg = [int(n) for n in input().split()]
        

        aux = custo
        while i < n -1:
            if numPac[i] > numPac[i+1]:

                auxp = numPac[i]
                numPac[i] = numPac[i+1]
                numPac[i+1] = auxp

                auxs = numSeg[i]
                numSeg[i] = numSeg[i+1]
                numSeg[i+1] = auxs
                
                custo += numSeg[i] + numSeg[i + 1]
            i += 1
   
        print(custo)
            

    except EOFError:
        break