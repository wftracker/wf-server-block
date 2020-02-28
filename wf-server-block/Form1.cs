using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_server_block
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void RemoveFirewallRule(string RuleName = "BreakermindCom")
        {
            try
            {
                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
                var currentProfiles = fwPolicy2.CurrentProfileTypes;

                List<INetFwRule> RuleList = new List<INetFwRule>();

                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name.IndexOf(RuleName) != -1)
                    {
                        INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                        firewallPolicy.Rules.Remove(rule.Name);
                    }
                }
            }
            catch (Exception r)
            {

            }
        }

        public bool IsRule(string RuleName = "BreakermindCom")
        {
            try
            {
                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
                var currentProfiles = fwPolicy2.CurrentProfileTypes;

                List<INetFwRule> RuleList = new List<INetFwRule>();

                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name.IndexOf(RuleName) != -1)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception r)
            {
                return false;
            }
        }

        public static void AddFirewallRuleOut(string ruleName, string ipRange)
        {
            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
            var currentProfiles = fwPolicy2.CurrentProfileTypes;
            INetFwRule2 outboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            outboundRule.Enabled = true;
            outboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            outboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            outboundRule.RemoteAddresses = ipRange;
            outboundRule.Name = ruleName;
            outboundRule.Profiles = currentProfiles;
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(outboundRule);
        }
        public static void AddFirewallRuleIn(string ruleName, string ipRange)
        {
            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
            var currentProfiles = fwPolicy2.CurrentProfileTypes;
            INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            inboundRule.Enabled = true;
            inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            inboundRule.RemoteAddresses = ipRange;
            inboundRule.Name = ruleName;
            inboundRule.Profiles = currentProfiles;
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(inboundRule);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (IsRule("HK-OUT"))
            {
                hkEnable.Text = "DISABLE";
            }
            if (IsRule("SG-OUT"))
            {
                sgEnable.Text = "DISABLE";
            }
            if (IsRule("SJ-OUT"))
            {
                sjEnable.Text = "DISABLE";
            }
            if (IsRule("DS-OUT"))
            {
                dsEnable.Text = "DISABLE";
            }

        }


        private void hkEnable_Click(object sender, EventArgs e)
        {
            if (hkEnable.Text == "DISABLE")
            {
                RemoveFirewallRule("HK-OUT");
                RemoveFirewallRule("HK-IN");
                hkEnable.Text = "ENABLE";
            }
            else
            {
                AddFirewallRuleOut("HK-OUT", "103.70.3.0/24");
                AddFirewallRuleIn("HK-IN", "103.70.3.0/24");
                hkEnable.Text = "DISABLE";
            }
        }

        private void sgEnable_Click_1(object sender, EventArgs e)
        {
            if (sgEnable.Text == "DISABLE")
            {
                RemoveFirewallRule("SG-OUT");
                RemoveFirewallRule("SG-IN");
                sgEnable.Text = "ENABLE";
            }
            else
            {
                AddFirewallRuleOut("SG-OUT", "103.23.211.0/24");
                AddFirewallRuleIn("SG-IN", "103.23.211.0/24");
                sgEnable.Text = "DISABLE";
            }
        }

        private void sjEnable_Click_1(object sender, EventArgs e)
        {
            if (sjEnable.Text == "DISABLE")
            {
                RemoveFirewallRule("SJ-OUT");
                RemoveFirewallRule("SJ-IN");
                sjEnable.Text = "ENABLE";
            }
            else
            {

                AddFirewallRuleOut("SJ-OUT", "192.31.179.0/24");
                AddFirewallRuleIn("SJ-IN", "192.31.179.0/24");
                sjEnable.Text = "DISABLE";
            }
        }

        private void dsEnable_Click_1(object sender, EventArgs e)
        {
            if (dsEnable.Text == "DISABLE")
            {
                RemoveFirewallRule("DS-OUT");
                RemoveFirewallRule("DS-IN");
                dsEnable.Text = "ENABLE";
            }
            else
            {
                AddFirewallRuleOut("DS-OUT", "64.58.126.0/24");
                AddFirewallRuleIn("DS-IN", "64.58.126.0/24");
                dsEnable.Text = "DISABLE";
            }
        }
    }
}
