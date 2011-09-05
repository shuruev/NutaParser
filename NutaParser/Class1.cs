using System;
using System.IO;
using System.Configuration;

namespace CC.PA2.Utils
{
	public class ProcInfo
	{
		private bool m_bIsEmpty = true;
		private bool m_bIsHTML = true;
		private string m_strLog = null;
		private string m_strMsg = null;
		private string m_spr = "\n";
		private DateTime l_oDT0, l_oDT;

		static ProcInfo()
		{
		}

		public bool HTMLOutput
		{
			set
			{
				m_bIsHTML = value;
				if (m_bIsHTML) { m_spr = "<br/>"; }
				else { m_spr = "\n"; }
			}
			get { return m_bIsHTML; }
		}

		public bool GetException(Exception e)
		{
			AddToLog(e.StackTrace);
			return true;
		}

		public bool IsEmpty
		{
			get { return m_bIsEmpty; }
		}

		public string Log
		{
			get { return m_strLog; }
		}

		public string Message
		{
			set
			{
				m_strMsg = value;
				AddToLog(m_strMsg);
			}
			get { return m_strMsg; }
		}

		private void AddToLog(string Msg)
		{
			l_oDT = DateTime.Now;
			if (m_bIsEmpty) l_oDT0 = l_oDT;
			m_strLog += l_oDT.ToString() + '\t' + Msg + "\t(" + (l_oDT - l_oDT0).TotalMilliseconds + ')' + m_spr;
			l_oDT0 = l_oDT;
			m_bIsEmpty = false;
		}
	}
}
