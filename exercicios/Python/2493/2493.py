while True:
    try:
        t = int(input())

        li_Sign = [" "] * t

        for i in range(t):
            exp = input()
            newExp = exp.replace("="," ")
            li = list(newExp.split(" "))   

            if int(li[0]) + int(li[1]) == int(li[2]):
                li_Sign[i] = '+'
            elif int(li[0]) - int(li[1]) == int(li[2]):
                li_Sign[i] = '-'
            elif int(li[0]) * int(li[1]) == int(li[2]):
                li_Sign[i] = '*'
            else:
                li_Sign[i] = 'I'

        result = []
        flag = 0
        for i in range(t):
            str = input()
            li_name = list(str.split(" "))
            index = int(li_name[1])

            if li_Sign[index - 1] != li_name[2]:
                result.append(li_name[0])
                flag += 1

        if flag == 0:
            print("You Shall All Pass!")
        elif flag == t:
            print("None Shall Pass!")
        else:
            result.sort()
            print(*result)

    except EOFError:
        break
