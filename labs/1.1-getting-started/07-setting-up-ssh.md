# Setting Up SSH

This is no longer the recommended approach by GitHub. Only execute
these steps if you prefer SSH.

## Generate an SSH key

Generate a new public/private key pair:

![keygen](../../img/git-ssh-1.png)

_(change the email address to yours)_

You will have to:

- enter a file location (you can use the default if you haven't already generated a key in the past)
- enter a password
- confirm the password

A password isn't actually required, but it's recommended.

## Add the key to ssh-agent

Check if ssh-agent is running. Start it if it isn't:

![Starting ssh-agent](../../img/git-ssh-2.png)

Add your key to the agent:

![Adding key on Windows](../../img/git-ssh-3.png)

### Important for Mac OS X

Mac users should use the following command to add the key:

```
ssh-add -K ~/.ssh/id_rsa
```

If you are running OS X Sierra 10.12.2 or later, modify `~/.ssh/config` to include:

```
Host *
  AddKeysToAgent yes
  UseKeychain yes
  IdentityFile ~/.ssh/id_rsa
```

## Add Public Key to GitHub

Copy the contents of your **public** key to the clipboard. You can open the file with a text editor.

Make sure it's the public key (a file that ends in `.pub`). Its contents should look like this:

![Public key](../../img/git-ssh-4.png)

Notice how it starts with `ssh-rsa` and ends with the email address provided when generating the key.

Now go to GitHub and open the settings:

![GitHub settings](../../img/git-ssh-5.png)

On the left, choose "SSH and GPG keys":

![GitHub keys](../../img/git-ssh-6.png)

Click on the green "New SSH key" button:

![New SSH key](../../img/git-ssh-7.png)

Give the key a descriptive name and paste the contents of the public key:

![Pasting key](../../img/git-ssh-8.png)

Make sure you copy the entire contents of the public key file, including any newlines. Don't remove or add anything.

Click the green "Add SSH key" button and you should see the key added:

![SSH key](../../img/git-ssh-9.png)
