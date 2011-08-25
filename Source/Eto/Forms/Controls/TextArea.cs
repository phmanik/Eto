using System;
using System.Collections;

namespace Eto.Forms
{
	public interface ITextArea : ITextControl
	{
		bool ReadOnly { get; set; }
		
		void Append(string text, bool scrollToCursor);
	}
	
	public class TextArea : TextControl
	{
		ITextArea inner;

		public TextArea()
			: this(Generator.Current)
		{
		}

		public TextArea(Generator g) : base(g, typeof(ITextArea))
		{
			inner = (ITextArea)base.Handler;
		}
		
		public bool ReadOnly
		{
			get { return inner.ReadOnly; }
			set { inner.ReadOnly = value; }
		}
		
		public void Append(string text, bool scrollToCursor = false)
		{
			inner.Append (text, scrollToCursor);
		}
	}
}
