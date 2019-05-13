# Rebasing

Leave the feature4 branch intact and switch to the master branch:

![Checkout master](../../img/git-checkout-master.png)
 
Create some commits on your master branch. Your log should look like this:

![Git log](../../img/git-before-rebase.png)

Switch back to your feature4 branch and look at the log:

![Git log](../../img/git-log-7.png)
 
Notice the hash (`6dcb3d2`).

Now rebase onto master:

![Git rebase](../../img/git-rebase.png)
 
Look at the log again:

![Git log](../../img/git-log-8.png)
 
The feature4 branch is now based off the last commit on master, and the feature4 commit has a new hash (`1eb7e17`).
