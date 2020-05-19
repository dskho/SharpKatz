﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static SharpKatz.Natives;

namespace SharpKatz.Credential
{
    class Logon
    {
        public LUID LogonId { get; set; }
        public string LogonType { get; set; }
        public int Session { get; set; }
        public FILETIME LogonTime { get; set; }
        public string UserName { get; set; }
        public string LogonDomain { get; set; }
        public string LogonServer { get; set; }
        public string SID { get; set; }

        public Msv Msv{ get; set; }
        public WDigest Wdigest { get; set; }
        public List<Ssp> Ssp { get; set; }
        public List<LiveSsp> LiveSsp { get; set; }
        public Tspkg Tspkg { get; set; }
        public Kerberos Kerberos { get; set; }
        public List<CredMan> Credman { get; set; }
        public List<KerberosKey> KerberosKeys { get; set; }

        public IntPtr pCredentials { get; set; }
        public IntPtr pCredentialManager { get; set; }

        public Logon(LUID logonId)
        {
            LogonId = logonId;
        }
    }

    class Msv
    {
        public string DomainName { get; set; }
        public string UserName { get; set; }
        public string Lm { get; set; }
        public string Ntlm { get; set; }
        public string Sha1 { get; set; }
        public string Dpapi { get; set; }

        public Msv()
        {
        }
    }

    class Ssp
    {
        public int Reference { get; set; }
        public string DomainName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Ssp()
        {
        }
    }

    class Tspkg
    {
        public string DomainName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Tspkg()
        {
        }
    }

    class Kerberos
    {
        public string DomainName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Kerberos()
        {
        }
    }

    class CredMan
    {
        public int Reference { get; set; }
        public string DomainName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public CredMan()
        {
        }
    }

    class LiveSsp
    {
        public string DomainName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public LiveSsp()
        {
        }
    }

    class WDigest
    {
        public string HostName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public WDigest()
        {
        }

    }

    class KerberosKey
    {
        public string Type { get; set; }
        public string Key { get; set; }

        public KerberosKey()
        {
        }

    }
}