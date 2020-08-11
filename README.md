Step to reproduce
====

Working (on a windows computer)
----
```
cd TestAspose
dotnet run
```

Not working (in docker)
----
```
cd TestAspose
docker build -t test-aspose .
docker run test-aspose
```