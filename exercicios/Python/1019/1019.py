N = int(input())

time =[3600, 60, 1]
result =[];

for time_s in time:
    qt_time = int(N / time_s);

    result.append(str(qt_time))

    N -= qt_time * time_s;

print(":".join(result));
