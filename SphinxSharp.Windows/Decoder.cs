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

public class Decoder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Decoder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Decoder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Decoder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PocketSphinxPINVOKE.delete_Decoder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Decoder() : this(PocketSphinxPINVOKE.new_Decoder__SWIG_0(), true) {
  }

  public Decoder(Config config) : this(PocketSphinxPINVOKE.new_Decoder__SWIG_1(Config.getCPtr(config)), true) {
  }

  public void reinit(Config config) {
    PocketSphinxPINVOKE.Decoder_reinit(swigCPtr, Config.getCPtr(config));
  }

  public void load_dict(string fdict, string ffilter, string format) {
    PocketSphinxPINVOKE.Decoder_load_dict(swigCPtr, fdict, ffilter, format);
  }

  public void save_dict(string dictfile, string format) {
    PocketSphinxPINVOKE.Decoder_save_dict(swigCPtr, dictfile, format);
  }

  public void add_word(string word, string phones, int update) {
    PocketSphinxPINVOKE.Decoder_add_word(swigCPtr, word, phones, update);
  }

  public string lookup_word(string word) {
    string ret = PocketSphinxPINVOKE.Decoder_lookup_word(swigCPtr, word);
    return ret;
  }

  public Lattice get_lattice() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_get_lattice(swigCPtr);
    Lattice ret = (cPtr == global::System.IntPtr.Zero) ? null : new Lattice(cPtr, false);
    return ret;
  }

  public Config get_config() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_get_config(swigCPtr);
    Config ret = (cPtr == global::System.IntPtr.Zero) ? null : new Config(cPtr, true);
    return ret;
  }

  public static Config default_config() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_default_config();
    Config ret = (cPtr == global::System.IntPtr.Zero) ? null : new Config(cPtr, true);
    return ret;
  }

  public static Config file_config(string path) {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_file_config(path);
    Config ret = (cPtr == global::System.IntPtr.Zero) ? null : new Config(cPtr, true);
    return ret;
  }

  public void start_stream() {
    PocketSphinxPINVOKE.Decoder_start_stream(swigCPtr);
  }

  public void start_utt() {
    PocketSphinxPINVOKE.Decoder_start_utt(swigCPtr);
  }

  public void end_utt() {
    PocketSphinxPINVOKE.Decoder_end_utt(swigCPtr);
  }

  public int process_raw(SWIGTYPE_p_unsigned_char SDATA, int SIZE, bool no_search, bool full_utt) {
    int ret = PocketSphinxPINVOKE.Decoder_process_raw(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(SDATA), SIZE, no_search, full_utt);
    return ret;
  }

  public Hypothesis hyp() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_hyp(swigCPtr);
    Hypothesis ret = (cPtr == global::System.IntPtr.Zero) ? null : new Hypothesis(cPtr, true);
    return ret;
  }

  public FrontEnd get_fe() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_get_fe(swigCPtr);
    FrontEnd ret = (cPtr == global::System.IntPtr.Zero) ? null : new FrontEnd(cPtr, false);
    return ret;
  }

  public Feature get_feat() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_get_feat(swigCPtr);
    Feature ret = (cPtr == global::System.IntPtr.Zero) ? null : new Feature(cPtr, false);
    return ret;
  }

  public bool get_in_speech() {
    bool ret = PocketSphinxPINVOKE.Decoder_get_in_speech(swigCPtr);
    return ret;
  }

  public FsgModel get_fsg(string name) {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_get_fsg(swigCPtr, name);
    FsgModel ret = (cPtr == global::System.IntPtr.Zero) ? null : new FsgModel(cPtr, false);
    return ret;
  }

  public void set_fsg(string name, FsgModel fsg) {
    PocketSphinxPINVOKE.Decoder_set_fsg(swigCPtr, name, FsgModel.getCPtr(fsg));
  }

  public void set_jsgf_file(string name, string path) {
    PocketSphinxPINVOKE.Decoder_set_jsgf_file(swigCPtr, name, path);
  }

  public void set_jsgf_string(string name, string jsgf_string) {
    PocketSphinxPINVOKE.Decoder_set_jsgf_string(swigCPtr, name, jsgf_string);
  }

  public string get_kws(string name) {
    string ret = PocketSphinxPINVOKE.Decoder_get_kws(swigCPtr, name);
    return ret;
  }

  public void set_kws(string name, string keyfile) {
    PocketSphinxPINVOKE.Decoder_set_kws(swigCPtr, name, keyfile);
  }

  public void set_keyphrase(string name, string keyphrase) {
    PocketSphinxPINVOKE.Decoder_set_keyphrase(swigCPtr, name, keyphrase);
  }

  public void set_allphone_file(string name, string lmfile) {
    PocketSphinxPINVOKE.Decoder_set_allphone_file(swigCPtr, name, lmfile);
  }

  public NGramModel get_lm(string name) {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_get_lm(swigCPtr, name);
    NGramModel ret = (cPtr == global::System.IntPtr.Zero) ? null : new NGramModel(cPtr, true);
    return ret;
  }

  public void set_lm(string name, NGramModel lm) {
    PocketSphinxPINVOKE.Decoder_set_lm(swigCPtr, name, NGramModel.getCPtr(lm));
  }

  public void set_lm_file(string name, string path) {
    PocketSphinxPINVOKE.Decoder_set_lm_file(swigCPtr, name, path);
  }

  public LogMath get_logmath() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_get_logmath(swigCPtr);
    LogMath ret = (cPtr == global::System.IntPtr.Zero) ? null : new LogMath(cPtr, true);
    return ret;
  }

  public void set_search(string search_name) {
    PocketSphinxPINVOKE.Decoder_set_search(swigCPtr, search_name);
  }

  public void unset_search(string search_name) {
    PocketSphinxPINVOKE.Decoder_unset_search(swigCPtr, search_name);
  }

  public string get_search() {
    string ret = PocketSphinxPINVOKE.Decoder_get_search(swigCPtr);
    return ret;
  }

  public int n_frames() {
    int ret = PocketSphinxPINVOKE.Decoder_n_frames(swigCPtr);
    return ret;
  }

  public SegmentList seg() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_seg(swigCPtr);
    SegmentList ret = (cPtr == global::System.IntPtr.Zero) ? null : new SegmentList(cPtr, false);
    return ret;
  }

  public NBestList nbest() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Decoder_nbest(swigCPtr);
    NBestList ret = (cPtr == global::System.IntPtr.Zero) ? null : new NBestList(cPtr, false);
    return ret;
  }

}

}
