_Information taken from the [original project](http://sshnet.codeplex.com/):_

# Introduction
This project was inspired by Sharp.SSH library which was ported from java and it seems like was not supported for quite some time. This library is complete rewrite using .NET 4.0, without any third party dependencies and to utilize the parallelism as much as possible to allow best performance I can get.

# Features
* Execution of SSH command using both synchronous and asynchronous methods
* Return command execution exit status and other information
* Provide SFTP functionality for both synchronous and asynchronous operations.
* Provides SCP functionality.
* Provide status report for upload and download sftp operations to allow accurate progress bar implementation
* Remote and local port forwarding
* Shell/Terminal implementation.
* Specify key file pass phrase
* Use multiple key files to authenticate
* Supports diffie-hellman-group-exchange-sha256, diffie-hellman-group-exchange-sha1, diffie-hellman-group14-sha1 and diffie-hellman-group1-sha1 key exchange methods.
* Supports 3des-cbc, aes128-cbc, aes192-cbc, aes256-cbc, aes128-ctr, aes192-ctr, aes256-ctr, blowfish-cbc and cast128-cbc encryptions.
* Supports hmac-md5 and hmac-sha1 hashing algorithms.
* Supports publickey, password and keyboard-interactive authentication methods
* Supports RSA and DSA private key
* Supports DES-EDE3-CBC, DES-EDE3-CFB, DES-CBC algorithms for private key encryption.
* Supports two-factor or higher authentication
* Supports .NET 3.5, Silverlight and Windows Phone
* Supports SOCKS4, SOCKS5 and HTTP Proxy

# Code Samples
Sample code can be found by looking at the test cases included in the source code. Make sure you read the code for tests that is not expected to fail.

# Future Features
* Compression support

# Samples and Documentation
[SshClient.chm](http://www.codeplex.com/Download?ProjectName=sshnet&DownloadId=191831)