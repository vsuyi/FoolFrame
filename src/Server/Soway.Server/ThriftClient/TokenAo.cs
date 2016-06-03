/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

public partial class TokenAo {
  public interface Iface {
    string getToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key);
    #if SILVERLIGHT
    IAsyncResult Begin_getToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key);
    string End_getToken(IAsyncResult asyncResult);
    #endif
    void updateToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key, string token, int expireSeconds);
    #if SILVERLIGHT
    IAsyncResult Begin_updateToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key, string token, int expireSeconds);
    void End_updateToken(IAsyncResult asyncResult);
    #endif
    void deleteToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key);
    #if SILVERLIGHT
    IAsyncResult Begin_deleteToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key);
    void End_deleteToken(IAsyncResult asyncResult);
    #endif
    string checkToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string token);
    #if SILVERLIGHT
    IAsyncResult Begin_checkToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string token);
    string End_checkToken(IAsyncResult asyncResult);
    #endif
  }

  public class Client : IDisposable, Iface {
    public Client(TProtocol prot) : this(prot, prot)
    {
    }

    public Client(TProtocol iprot, TProtocol oprot)
    {
      iprot_ = iprot;
      oprot_ = oprot;
    }

    protected TProtocol iprot_;
    protected TProtocol oprot_;
    protected int seqid_;

    public TProtocol InputProtocol
    {
      get { return iprot_; }
    }
    public TProtocol OutputProtocol
    {
      get { return oprot_; }
    }


    #region " IDisposable Support "
    private bool _IsDisposed;

    // IDisposable
    public void Dispose()
    {
      Dispose(true);
    }
    

    protected virtual void Dispose(bool disposing)
    {
      if (!_IsDisposed)
      {
        if (disposing)
        {
          if (iprot_ != null)
          {
            ((IDisposable)iprot_).Dispose();
          }
          if (oprot_ != null)
          {
            ((IDisposable)oprot_).Dispose();
          }
        }
      }
      _IsDisposed = true;
    }
    #endregion


    
    #if SILVERLIGHT
    public IAsyncResult Begin_getToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key)
    {
      return send_getToken(callback, state, platformArgs, key);
    }

    public string End_getToken(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_getToken();
    }

    #endif

    public string getToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key)
    {
      #if !SILVERLIGHT
      send_getToken(platformArgs, key);
      return recv_getToken();

      #else
      var asyncResult = Begin_getToken(null, null, platformArgs, key);
      return End_getToken(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_getToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key)
    #else
    public void send_getToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("getToken", TMessageType.Call, seqid_));
      getToken_args args = new getToken_args();
      args.PlatformArgs = platformArgs;
      args.Key = key;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public string recv_getToken()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      getToken_result result = new getToken_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.success) {
        return result.Success;
      }
      if (result.__isset.err) {
        throw result.Err;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "getToken failed: unknown result");
    }

    
    #if SILVERLIGHT
    public IAsyncResult Begin_updateToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key, string token, int expireSeconds)
    {
      return send_updateToken(callback, state, platformArgs, key, token, expireSeconds);
    }

    public void End_updateToken(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      recv_updateToken();
    }

    #endif

    public void updateToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key, string token, int expireSeconds)
    {
      #if !SILVERLIGHT
      send_updateToken(platformArgs, key, token, expireSeconds);
      recv_updateToken();

      #else
      var asyncResult = Begin_updateToken(null, null, platformArgs, key, token, expireSeconds);
      End_updateToken(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_updateToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key, string token, int expireSeconds)
    #else
    public void send_updateToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key, string token, int expireSeconds)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("updateToken", TMessageType.Call, seqid_));
      updateToken_args args = new updateToken_args();
      args.PlatformArgs = platformArgs;
      args.Key = key;
      args.Token = token;
      args.ExpireSeconds = expireSeconds;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public void recv_updateToken()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      updateToken_result result = new updateToken_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.err) {
        throw result.Err;
      }
      return;
    }

    
    #if SILVERLIGHT
    public IAsyncResult Begin_deleteToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key)
    {
      return send_deleteToken(callback, state, platformArgs, key);
    }

    public void End_deleteToken(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      recv_deleteToken();
    }

    #endif

    public void deleteToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key)
    {
      #if !SILVERLIGHT
      send_deleteToken(platformArgs, key);
      recv_deleteToken();

      #else
      var asyncResult = Begin_deleteToken(null, null, platformArgs, key);
      End_deleteToken(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_deleteToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key)
    #else
    public void send_deleteToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string key)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("deleteToken", TMessageType.Call, seqid_));
      deleteToken_args args = new deleteToken_args();
      args.PlatformArgs = platformArgs;
      args.Key = key;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public void recv_deleteToken()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      deleteToken_result result = new deleteToken_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.err) {
        throw result.Err;
      }
      return;
    }

    
    #if SILVERLIGHT
    public IAsyncResult Begin_checkToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string token)
    {
      return send_checkToken(callback, state, platformArgs, token);
    }

    public string End_checkToken(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_checkToken();
    }

    #endif

    public string checkToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string token)
    {
      #if !SILVERLIGHT
      send_checkToken(platformArgs, token);
      return recv_checkToken();

      #else
      var asyncResult = Begin_checkToken(null, null, platformArgs, token);
      return End_checkToken(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_checkToken(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string token)
    #else
    public void send_checkToken(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string token)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("checkToken", TMessageType.Call, seqid_));
      checkToken_args args = new checkToken_args();
      args.PlatformArgs = platformArgs;
      args.Token = token;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public string recv_checkToken()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      checkToken_result result = new checkToken_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.success) {
        return result.Success;
      }
      if (result.__isset.err) {
        throw result.Err;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "checkToken failed: unknown result");
    }

  }
  public class Processor : TProcessor {
    public Processor(Iface iface)
    {
      iface_ = iface;
      processMap_["getToken"] = getToken_Process;
      processMap_["updateToken"] = updateToken_Process;
      processMap_["deleteToken"] = deleteToken_Process;
      processMap_["checkToken"] = checkToken_Process;
    }

    protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
    private Iface iface_;
    protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

    public bool Process(TProtocol iprot, TProtocol oprot)
    {
      try
      {
        TMessage msg = iprot.ReadMessageBegin();
        ProcessFunction fn;
        processMap_.TryGetValue(msg.Name, out fn);
        if (fn == null) {
          TProtocolUtil.Skip(iprot, TType.Struct);
          iprot.ReadMessageEnd();
          TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
          oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
          x.Write(oprot);
          oprot.WriteMessageEnd();
          oprot.Transport.Flush();
          return true;
        }
        fn(msg.SeqID, iprot, oprot);
      }
      catch (IOException)
      {
        return false;
      }
      return true;
    }

    public void getToken_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      getToken_args args = new getToken_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      getToken_result result = new getToken_result();
      try {
        result.Success = iface_.getToken(args.PlatformArgs, args.Key);
      } catch (org.soldier.platform.svr_platform.comm.ErrorInfo err) {
        result.Err = err;
      }
      oprot.WriteMessageBegin(new TMessage("getToken", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void updateToken_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      updateToken_args args = new updateToken_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      updateToken_result result = new updateToken_result();
      try {
        iface_.updateToken(args.PlatformArgs, args.Key, args.Token, args.ExpireSeconds);
      } catch (org.soldier.platform.svr_platform.comm.ErrorInfo err) {
        result.Err = err;
      }
      oprot.WriteMessageBegin(new TMessage("updateToken", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void deleteToken_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      deleteToken_args args = new deleteToken_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      deleteToken_result result = new deleteToken_result();
      try {
        iface_.deleteToken(args.PlatformArgs, args.Key);
      } catch (org.soldier.platform.svr_platform.comm.ErrorInfo err) {
        result.Err = err;
      }
      oprot.WriteMessageBegin(new TMessage("deleteToken", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void checkToken_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      checkToken_args args = new checkToken_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      checkToken_result result = new checkToken_result();
      try {
        result.Success = iface_.checkToken(args.PlatformArgs, args.Token);
      } catch (org.soldier.platform.svr_platform.comm.ErrorInfo err) {
        result.Err = err;
      }
      oprot.WriteMessageBegin(new TMessage("checkToken", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class getToken_args : TBase
  {
    private org.soldier.platform.svr_platform.comm.PlatformArgs _platformArgs;
    private string _key;

    public org.soldier.platform.svr_platform.comm.PlatformArgs PlatformArgs
    {
      get
      {
        return _platformArgs;
      }
      set
      {
        __isset.platformArgs = true;
        this._platformArgs = value;
      }
    }

    public string Key
    {
      get
      {
        return _key;
      }
      set
      {
        __isset.key = true;
        this._key = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool platformArgs;
      public bool key;
    }

    public getToken_args() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              PlatformArgs = new org.soldier.platform.svr_platform.comm.PlatformArgs();
              PlatformArgs.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Key = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("getToken_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PlatformArgs != null && __isset.platformArgs) {
        field.Name = "platformArgs";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        PlatformArgs.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Key != null && __isset.key) {
        field.Name = "key";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Key);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("getToken_args(");
      sb.Append("PlatformArgs: ");
      sb.Append(PlatformArgs== null ? "<null>" : PlatformArgs.ToString());
      sb.Append(",Key: ");
      sb.Append(Key);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class getToken_result : TBase
  {
    private string _success;
    private org.soldier.platform.svr_platform.comm.ErrorInfo _err;

    public string Success
    {
      get
      {
        return _success;
      }
      set
      {
        __isset.success = true;
        this._success = value;
      }
    }

    public org.soldier.platform.svr_platform.comm.ErrorInfo Err
    {
      get
      {
        return _err;
      }
      set
      {
        __isset.err = true;
        this._err = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool success;
      public bool err;
    }

    public getToken_result() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 0:
            if (field.Type == TType.String) {
              Success = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 1:
            if (field.Type == TType.Struct) {
              Err = new org.soldier.platform.svr_platform.comm.ErrorInfo();
              Err.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("getToken_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.success) {
        if (Success != null) {
          field.Name = "Success";
          field.Type = TType.String;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Success);
          oprot.WriteFieldEnd();
        }
      } else if (this.__isset.err) {
        if (Err != null) {
          field.Name = "Err";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Err.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("getToken_result(");
      sb.Append("Success: ");
      sb.Append(Success);
      sb.Append(",Err: ");
      sb.Append(Err== null ? "<null>" : Err.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class updateToken_args : TBase
  {
    private org.soldier.platform.svr_platform.comm.PlatformArgs _platformArgs;
    private string _key;
    private string _token;
    private int _expireSeconds;

    public org.soldier.platform.svr_platform.comm.PlatformArgs PlatformArgs
    {
      get
      {
        return _platformArgs;
      }
      set
      {
        __isset.platformArgs = true;
        this._platformArgs = value;
      }
    }

    public string Key
    {
      get
      {
        return _key;
      }
      set
      {
        __isset.key = true;
        this._key = value;
      }
    }

    public string Token
    {
      get
      {
        return _token;
      }
      set
      {
        __isset.token = true;
        this._token = value;
      }
    }

    public int ExpireSeconds
    {
      get
      {
        return _expireSeconds;
      }
      set
      {
        __isset.expireSeconds = true;
        this._expireSeconds = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool platformArgs;
      public bool key;
      public bool token;
      public bool expireSeconds;
    }

    public updateToken_args() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              PlatformArgs = new org.soldier.platform.svr_platform.comm.PlatformArgs();
              PlatformArgs.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Key = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Token = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              ExpireSeconds = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("updateToken_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PlatformArgs != null && __isset.platformArgs) {
        field.Name = "platformArgs";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        PlatformArgs.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Key != null && __isset.key) {
        field.Name = "key";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Key);
        oprot.WriteFieldEnd();
      }
      if (Token != null && __isset.token) {
        field.Name = "token";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Token);
        oprot.WriteFieldEnd();
      }
      if (__isset.expireSeconds) {
        field.Name = "expireSeconds";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ExpireSeconds);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("updateToken_args(");
      sb.Append("PlatformArgs: ");
      sb.Append(PlatformArgs== null ? "<null>" : PlatformArgs.ToString());
      sb.Append(",Key: ");
      sb.Append(Key);
      sb.Append(",Token: ");
      sb.Append(Token);
      sb.Append(",ExpireSeconds: ");
      sb.Append(ExpireSeconds);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class updateToken_result : TBase
  {
    private org.soldier.platform.svr_platform.comm.ErrorInfo _err;

    public org.soldier.platform.svr_platform.comm.ErrorInfo Err
    {
      get
      {
        return _err;
      }
      set
      {
        __isset.err = true;
        this._err = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool err;
    }

    public updateToken_result() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              Err = new org.soldier.platform.svr_platform.comm.ErrorInfo();
              Err.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("updateToken_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.err) {
        if (Err != null) {
          field.Name = "Err";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Err.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("updateToken_result(");
      sb.Append("Err: ");
      sb.Append(Err== null ? "<null>" : Err.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class deleteToken_args : TBase
  {
    private org.soldier.platform.svr_platform.comm.PlatformArgs _platformArgs;
    private string _key;

    public org.soldier.platform.svr_platform.comm.PlatformArgs PlatformArgs
    {
      get
      {
        return _platformArgs;
      }
      set
      {
        __isset.platformArgs = true;
        this._platformArgs = value;
      }
    }

    public string Key
    {
      get
      {
        return _key;
      }
      set
      {
        __isset.key = true;
        this._key = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool platformArgs;
      public bool key;
    }

    public deleteToken_args() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              PlatformArgs = new org.soldier.platform.svr_platform.comm.PlatformArgs();
              PlatformArgs.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Key = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("deleteToken_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PlatformArgs != null && __isset.platformArgs) {
        field.Name = "platformArgs";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        PlatformArgs.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Key != null && __isset.key) {
        field.Name = "key";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Key);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("deleteToken_args(");
      sb.Append("PlatformArgs: ");
      sb.Append(PlatformArgs== null ? "<null>" : PlatformArgs.ToString());
      sb.Append(",Key: ");
      sb.Append(Key);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class deleteToken_result : TBase
  {
    private org.soldier.platform.svr_platform.comm.ErrorInfo _err;

    public org.soldier.platform.svr_platform.comm.ErrorInfo Err
    {
      get
      {
        return _err;
      }
      set
      {
        __isset.err = true;
        this._err = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool err;
    }

    public deleteToken_result() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              Err = new org.soldier.platform.svr_platform.comm.ErrorInfo();
              Err.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("deleteToken_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.err) {
        if (Err != null) {
          field.Name = "Err";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Err.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("deleteToken_result(");
      sb.Append("Err: ");
      sb.Append(Err== null ? "<null>" : Err.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class checkToken_args : TBase
  {
    private org.soldier.platform.svr_platform.comm.PlatformArgs _platformArgs;
    private string _token;

    public org.soldier.platform.svr_platform.comm.PlatformArgs PlatformArgs
    {
      get
      {
        return _platformArgs;
      }
      set
      {
        __isset.platformArgs = true;
        this._platformArgs = value;
      }
    }

    public string Token
    {
      get
      {
        return _token;
      }
      set
      {
        __isset.token = true;
        this._token = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool platformArgs;
      public bool token;
    }

    public checkToken_args() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              PlatformArgs = new org.soldier.platform.svr_platform.comm.PlatformArgs();
              PlatformArgs.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Token = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("checkToken_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PlatformArgs != null && __isset.platformArgs) {
        field.Name = "platformArgs";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        PlatformArgs.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Token != null && __isset.token) {
        field.Name = "token";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Token);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("checkToken_args(");
      sb.Append("PlatformArgs: ");
      sb.Append(PlatformArgs== null ? "<null>" : PlatformArgs.ToString());
      sb.Append(",Token: ");
      sb.Append(Token);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class checkToken_result : TBase
  {
    private string _success;
    private org.soldier.platform.svr_platform.comm.ErrorInfo _err;

    public string Success
    {
      get
      {
        return _success;
      }
      set
      {
        __isset.success = true;
        this._success = value;
      }
    }

    public org.soldier.platform.svr_platform.comm.ErrorInfo Err
    {
      get
      {
        return _err;
      }
      set
      {
        __isset.err = true;
        this._err = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool success;
      public bool err;
    }

    public checkToken_result() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 0:
            if (field.Type == TType.String) {
              Success = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 1:
            if (field.Type == TType.Struct) {
              Err = new org.soldier.platform.svr_platform.comm.ErrorInfo();
              Err.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("checkToken_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.success) {
        if (Success != null) {
          field.Name = "Success";
          field.Type = TType.String;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Success);
          oprot.WriteFieldEnd();
        }
      } else if (this.__isset.err) {
        if (Err != null) {
          field.Name = "Err";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Err.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("checkToken_result(");
      sb.Append("Success: ");
      sb.Append(Success);
      sb.Append(",Err: ");
      sb.Append(Err== null ? "<null>" : Err.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
