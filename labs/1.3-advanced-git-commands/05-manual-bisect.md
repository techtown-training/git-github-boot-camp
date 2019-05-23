# Manual Bisect

If you haven't yet cloned it, clone this repository by running this command (in a directory that isn't a Git repository):

```
git clone git@github.com:techtown-training/git-github-boot-camp.git
```

Switch to the `bisect-project` folder:

```
cd bisect-project
```

Run an addition to see that it works:

![Run add](../../img/git-bisect.png)

Run a subtraction to see that it doesn't produce the correct result:

![Run subtract](../../img/git-bisect-2.png)
 
Look at the log:

![Git log](../../img/git-bisect-3.png)
 
Let's assume we know the bug wasn't there when the minus operation was first implemented. This means it must have been introduced between commit `f0fc406` and `155e37d`.

Start a bisect and tell Git the last known good commit and the first known bad commit (move to the root of your repository first by running `cd ..`):

![Starting bisect](../../img/git-bisect-4.png)
 
Now run the subtraction again:

![Subtracting again](../../img/git-bisect-5.png)
 
The result is still wrong, so tell Git this is a bad commit:

![Bad commit](../../img/git-bisect-6.png)
 
Run the subtraction again. If the result is wrong again, do another `git bisect bad` and run the subtraction again. The result should be now correct:

![Good commit](../../img/git-bisect-7.png)
 
So tell Git this is a good commit:

![Good commit](../../img/git-bisect-8.png)
 
You can see the details of the commit by running `git show <commit-id>`:

![Commit details](../../img/git-bisect-9.png)

See how we introduced a bug there?

Exit the bisect session by calling `git bisect reset`:

![Exit bisect](../../img/git-bisect-10.png)
