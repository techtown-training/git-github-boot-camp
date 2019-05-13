# Interactive Rebasing

Switch to the `feature4` branch and add some more commits so you have a log with several commits on the branch:

![Git log](../../img/git-log-9.png)
 
Now rebase interactively onto master:

![Interactive rebase](../../img/git-rebase-master.png)
 
Your editor will open:

![Rebasing](../../img/git-rebase-i.png)
 
Now change it to:

![Rebasing](../../img/git-rebase-i-2.png)
 
We will:
- Reword the first commit
- Move the second commit to the end
- Squash the other two commits into one and keep the first commit message

Check the result in your log:
 
![Git log](../../img/git-log-10.png)
