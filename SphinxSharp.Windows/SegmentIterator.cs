//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Pocketsphinx {

public class SegmentIterator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SegmentIterator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SegmentIterator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SegmentIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PocketSphinxPINVOKE.delete_SegmentIterator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_ps_seg_t ptr {
    set {
      PocketSphinxPINVOKE.SegmentIterator_ptr_set(swigCPtr, SWIGTYPE_p_ps_seg_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = PocketSphinxPINVOKE.SegmentIterator_ptr_get(swigCPtr);
      SWIGTYPE_p_ps_seg_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ps_seg_t(cPtr, false);
      return ret;
    } 
  }

  public SegmentIterator(SWIGTYPE_p_ps_seg_t ptr) : this(PocketSphinxPINVOKE.new_SegmentIterator(SWIGTYPE_p_ps_seg_t.getCPtr(ptr)), true) {
  }

}

}
