# Manual Bisect

For this section, we'll use a repository that contains some actual code.

Clone the repository:

Build the project:

![Build](../../img/git-bisect.png)
 
Run an addition to see that it works:

![Run add](../../img/git-bisect-2.png)

Run a subtraction to see that it doesn't produce the correct result:

![Run subtract](../../img/git-bisect-3.png)
 
Look at the log:

![Git log](../../img/git-bisect-4.png)
 
Let's assume we know the bug wasn't there when console app was implemented. This means it must have been introduced between commit `6fd50cf` and `b585293`.

Start a bisect and tell Git the last known good commit and the first known bad commit:

![Starting bisect](../../img/git-bisect-5.png)
 
Now build the application and run the subtraction again:

![Subtracting again](../../img/git-bisect-6.png)
 
The result is still wrong, so tell Git this is a bad commit:

![Bad commit](../../img/git-bisect-7.png)
 
Build and run the application again. The result should be correct:

![Bad commit](../../img/git-bisect-8.png)
 
So tell Git this is a good commit:

![Good commit](../../img/git-bisect-9.png)
 
You can see the details of the commit by running `git show <commit-id>`:

![Commit details](../../img/git-bisect-10.png)

Exit the bisect session by calling `git bisect reset`:

![Exit bisect](../../img/git-bisect-11.png)
