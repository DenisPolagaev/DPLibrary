using System.Net;
using System.Security;
using DPLibrary.DPNet.SMB;
using NUnit.Framework;

namespace DPLibraryTest.DPNet.SMB
{
    [TestFixture]
    public class SmbConnectionTest
    {
        [Test]
        public void IsConnection()
        {
            SecureString password = new SecureString();
            NetworkCredential networkCredential = new NetworkCredential("operator", "planeta");
            //NetworkCredential networkCredential = new NetworkCredential("login", password);
            //NetworkCredential networkCredential = new NetworkCredential("login", "password");
            //NetworkCredential networkCredential = new NetworkCredential("login", "password", "domain");
            //NetworkCredential networkCredential = new NetworkCredential("login", password, "domain");
            
            using (var smb = new NetworkSMBConnection(@"network\path", networkCredential))
            {
                // Code
            }
        }
    }
}