# Automatic Bisect

First, create a script that will return exit code 1 if the result is not correct:

```
#!/usr/bin/env bash

if [ $(./bisect-project/calculator.sh 4 minus 2 | grep -c "4 minus 2 is 2") -ne 1 ]
then
    exit 1
fi

exit 0
```

Save this file as a Bash file (e.g., `bisect.sh`). On Windows, you’ll have to run this in Git Bash.

Be sure to make the script executable (this might not be necessary on Windows):

![Make executable](../../img/git-bisect-auto-0.png)

To start the bisect session, tell Git to start a bisect session and what the good and bad commits are:

![Starting bisect](../../img/git-bisect-auto-1.png)
 
Now, tell Git which command to run:

![Bisect run](../../img/git-bisect-auto-2.png)
 
Git will now run the script for several commits. In the end, it will find the commit that introduced the bug:

![Bad commit](../../img/git-bisect-auto-3.png)
 
Exit the bisect session:
 
![Exiting bisect](../../img/git-bisect-auto-4.png)

You can remove the `bisect.sh` script now if you want:

```
rm ./bisect.sh
```
