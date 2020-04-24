# Automated Code Scanning Demonstration
- [LGTM for OSS](https://github.com/marketplace/lgtm)
- Branch out for 
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
- Review [this PR](https://github.com/tony-lab/hello-dotnetcore/pull/4)
  - Queries database
  - [supported programming languages](https://help.semmle.com/lgtm-enterprise/admin/help/sys-requirements/language-support.html)
  - Query Console
  - [CodeQL repo](https://github.com/semmle/ql)
  - [SQL Injection](https://help.semmle.com/wiki/display/JAVA/Query+built+from+user-controlled+sources)
- if we still have time, then let's review [LGTM: apache/acivemq](https://lgtm.com/projects/g/apache/activemq?mode=list)
  - Show Paths
  - CodeQL Query Console
