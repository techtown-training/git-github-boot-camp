# Hooks

We'll create a commit hook that tells us our commit message should follow a certain pattern.

Create a `commit-msg` file in the `.git/hooks` folder:

![Create hook file](../../img/git-hook-1.png)
 
Put this Bash script in the file:

```
#!/bin/bash

pattern="#[0-9]{4}: .{1,}"

if [[ ! $(cat $1) =~ $pattern ]]
then
  echo Please provide a commit message that matches this format: "#<4-digit-ticket-number>: <commit message>", e.g.: "#8554: Fix login".
  exit 1
fi
```

Be sure to make the script executable (this might not be necessary on Windows):

![Make hook file executable](../../img/git-hook-2.png)

Edit a file and then try to commit it with the wrong commit message format:

![Wrong commit message](../../img/git-hook-3.png)
 
Verify that the commit hasn't occurred:

![Git log](../../img/git-hook-4.png)
 
Now try to commit with a correctly formatted message:

![Correct commit message](../../img/git-hook-5.png)
 
The change will now be committed:

![Git log](../../img/git-hook-6.png)

Remove the `commit-msg` file:

![Git log](../../img/git-hook-7.png)
