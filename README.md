[![Total alerts](https://img.shields.io/lgtm/alerts/g/tony-lab/hello-dotnetcore.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/tony-lab/hello-dotnetcore/alerts/)


# Automated Code Scanning Demonstration
- [LGTM for OSS](https://github.com/marketplace/lgtm)
- walk through [CodeQL Action](https://github.com/tony-lab/hello-dotnetcore/blob/master/.github/workflows/codeql.yml)
- walk through [CodeQL config](https://github.com/tony-lab/hello-dotnetcore/blob/master/.github/codeql/lgtm-config.yml)
- Edit [Program.cs](https://github.com/tony-lab/hello-dotnetcore/edit/master/ConsoleApp1/Program.cs) with below content,
```
using System;

namespace ConsoleApp1
{
    class Program
    {
        public class Person
        {
            public string Fullname { get; set; }
        }
        
        static void Main(string[] args)
        {
            Person tony = null;
            System.Console.WriteLine(tony.ToString());

            // fixing bug 12345
            // commit without GPG signing, even administrator
            // from git tower
            Console.WriteLine("Hello Auth0 Vulnerability with Actions!");
        }
    }
}
```
- Commit and creat new PR
- Review [this LGTM PR](https://github.com/tony-lab/hello-dotnetcore/pull/4) | [CodeQL Action PR](https://github.com/tony-lab/hello-dotnetcore/pull/42)
  - Queries database
  - [supported programming languages](https://help.semmle.com/lgtm-enterprise/admin/help/sys-requirements/language-support.html)
  - Query Console
  - [CodeQL repo](https://github.com/semmle/ql)
  - [SQL Injection](https://help.semmle.com/wiki/display/JAVA/Query+built+from+user-controlled+sources)
- if we still have time, then let's review [LGTM: apache/acivemq](https://lgtm.com/projects/g/apache/activemq?mode=list)
  - Show Paths
  - CodeQL Query Console

----

![workflow](https://user-images.githubusercontent.com/6351798/48032310-63842400-e114-11e8-8db0-06dc0504dcb5.png)
