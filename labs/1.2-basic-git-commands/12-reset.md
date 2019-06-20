# Git Reset

## Staged Changes

Make change to a file and stage it to be committed:

![Change file](../../img/git-reset-1.png)

Check the status:

![Status](../../img/git-reset-2.png)

You can unstage the change by using git reset:

![Reset](../../img/git-reset-3.png)

Check the status again:

![Status](../../img/git-reset-4.png)

The file is still modified, but no longer staged. You can undo the changes
by checking it out:

![Check out](../../img/git-reset-5.png)

## To Previous Commits

Check the log:

![Git log](../../img/git-reset-6.png)

Add some commits and check the log again:

![Git log](../../img/git-reset-7.png)

Let's reset back to the commit before our most recent changes (`e8d0bef` in our screenshot):

![Git Reset](../../img/git-reset-8.png)

Check the log to verify that our commits have gone:

![Git log](../../img/git-reset-6.png)

But our changes are still available locally:

![Git status](../../img/git-reset-9.png)
