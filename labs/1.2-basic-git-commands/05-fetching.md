# Fetching from a Remote

Currently, we are in sync with our remote. You can verify by checking the status:

![Git status](../../img/git-fetch-status.png)

Let's change something in the remote, but not in our local repository. This simulates a change by someone else.
Go to your repository on github.com and click on a file under the "Code" tab:

![GitHub repository](../../img/github-repo.png)
 
Click on the pencil icon to edit this file online:

![GitHub file](../../img/github-file.png)
 
Edit the file by adding some text:

![GitHub file editing](../../img/github-file-2.png)
 
Add a commit message and commit the change:

![GitHub file editing](../../img/github-file-3.png)

Now fetch these changes, without merging them into your working directory:

![Git fetch](../../img/git-fetch.png)

If you check the status now, you will see we're one commit behind:

![Git status](../../img/git-fetch-status-2.png)
 
Check the file on your machine to verify the change isn't in your working directory yet:

![Vim](../../img/git-fetch-cat.png)
