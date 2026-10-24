// NOTE: This file is auto-generated.
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.CompilerServices;
using System.Text;

namespace Miniaudio;

public static unsafe partial class Interop
{
    // Custom marshaller for library-owned strings returned by the library.
    [CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedOut, typeof(LibraryOwnedStringMarshaller))]
    public static unsafe class LibraryOwnedStringMarshaller
    {
        /// <summary>
        /// Converts an unmanaged string to a managed version.
        /// </summary>
        /// <returns>A managed string.</returns>
        public static string ConvertToManaged(byte* unmanaged)
            => Marshal.PtrToStringUTF8((IntPtr)unmanaged);
    }

    // Taken from https://github.com/ppy/SDL3-CS
    // C# bools are not blittable, so we need this workaround
    public readonly record struct NativeBool
    {
        private readonly byte value;

        internal const byte FALSE_VALUE = 0;
        internal const byte TRUE_VALUE = 1;

        internal NativeBool(byte value)
        {
            this.value = value;
        }

        public static implicit operator bool(NativeBool b)
        {
            return b.value != FALSE_VALUE;
        }

        public static implicit operator NativeBool(bool b)
        {
            return new NativeBool(b ? TRUE_VALUE : FALSE_VALUE);
        }

        public bool Equals(NativeBool other)
        {
            return other.value == value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }

    private const string nativeLibName = "miniaudio";

    // ../miniaudio/miniaudio.h

    public enum ma_log_level
    {
        MA_LOG_LEVEL_DEBUG = 4,
        MA_LOG_LEVEL_INFO = 3,
        MA_LOG_LEVEL_WARNING = 2,
        MA_LOG_LEVEL_ERROR = 1,
    }

    public enum _ma_channel_position
    {
        MA_CHANNEL_NONE = 0,
        MA_CHANNEL_MONO = 1,
        MA_CHANNEL_FRONT_LEFT = 2,
        MA_CHANNEL_FRONT_RIGHT = 3,
        MA_CHANNEL_FRONT_CENTER = 4,
        MA_CHANNEL_LFE = 5,
        MA_CHANNEL_BACK_LEFT = 6,
        MA_CHANNEL_BACK_RIGHT = 7,
        MA_CHANNEL_FRONT_LEFT_CENTER = 8,
        MA_CHANNEL_FRONT_RIGHT_CENTER = 9,
        MA_CHANNEL_BACK_CENTER = 10,
        MA_CHANNEL_SIDE_LEFT = 11,
        MA_CHANNEL_SIDE_RIGHT = 12,
        MA_CHANNEL_TOP_CENTER = 13,
        MA_CHANNEL_TOP_FRONT_LEFT = 14,
        MA_CHANNEL_TOP_FRONT_CENTER = 15,
        MA_CHANNEL_TOP_FRONT_RIGHT = 16,
        MA_CHANNEL_TOP_BACK_LEFT = 17,
        MA_CHANNEL_TOP_BACK_CENTER = 18,
        MA_CHANNEL_TOP_BACK_RIGHT = 19,
        MA_CHANNEL_AUX_0 = 20,
        MA_CHANNEL_AUX_1 = 21,
        MA_CHANNEL_AUX_2 = 22,
        MA_CHANNEL_AUX_3 = 23,
        MA_CHANNEL_AUX_4 = 24,
        MA_CHANNEL_AUX_5 = 25,
        MA_CHANNEL_AUX_6 = 26,
        MA_CHANNEL_AUX_7 = 27,
        MA_CHANNEL_AUX_8 = 28,
        MA_CHANNEL_AUX_9 = 29,
        MA_CHANNEL_AUX_10 = 30,
        MA_CHANNEL_AUX_11 = 31,
        MA_CHANNEL_AUX_12 = 32,
        MA_CHANNEL_AUX_13 = 33,
        MA_CHANNEL_AUX_14 = 34,
        MA_CHANNEL_AUX_15 = 35,
        MA_CHANNEL_AUX_16 = 36,
        MA_CHANNEL_AUX_17 = 37,
        MA_CHANNEL_AUX_18 = 38,
        MA_CHANNEL_AUX_19 = 39,
        MA_CHANNEL_AUX_20 = 40,
        MA_CHANNEL_AUX_21 = 41,
        MA_CHANNEL_AUX_22 = 42,
        MA_CHANNEL_AUX_23 = 43,
        MA_CHANNEL_AUX_24 = 44,
        MA_CHANNEL_AUX_25 = 45,
        MA_CHANNEL_AUX_26 = 46,
        MA_CHANNEL_AUX_27 = 47,
        MA_CHANNEL_AUX_28 = 48,
        MA_CHANNEL_AUX_29 = 49,
        MA_CHANNEL_AUX_30 = 50,
        MA_CHANNEL_AUX_31 = 51,
        MA_CHANNEL_POSITION_COUNT = 52,
        MA_CHANNEL_LEFT = 2,
        MA_CHANNEL_RIGHT = 3,
    }

    public enum ma_result
    {
        MA_SUCCESS = 0,
        MA_ERROR = -1,
        MA_INVALID_ARGS = -2,
        MA_INVALID_OPERATION = -3,
        MA_OUT_OF_MEMORY = -4,
        MA_OUT_OF_RANGE = -5,
        MA_ACCESS_DENIED = -6,
        MA_DOES_NOT_EXIST = -7,
        MA_ALREADY_EXISTS = -8,
        MA_TOO_MANY_OPEN_FILES = -9,
        MA_INVALID_FILE = -10,
        MA_TOO_BIG = -11,
        MA_PATH_TOO_LONG = -12,
        MA_NAME_TOO_LONG = -13,
        MA_NOT_DIRECTORY = -14,
        MA_IS_DIRECTORY = -15,
        MA_DIRECTORY_NOT_EMPTY = -16,
        MA_AT_END = -17,
        MA_NO_SPACE = -18,
        MA_BUSY = -19,
        MA_IO_ERROR = -20,
        MA_INTERRUPT = -21,
        MA_UNAVAILABLE = -22,
        MA_ALREADY_IN_USE = -23,
        MA_BAD_ADDRESS = -24,
        MA_BAD_SEEK = -25,
        MA_BAD_PIPE = -26,
        MA_DEADLOCK = -27,
        MA_TOO_MANY_LINKS = -28,
        MA_NOT_IMPLEMENTED = -29,
        MA_NO_MESSAGE = -30,
        MA_BAD_MESSAGE = -31,
        MA_NO_DATA_AVAILABLE = -32,
        MA_INVALID_DATA = -33,
        MA_TIMEOUT = -34,
        MA_NO_NETWORK = -35,
        MA_NOT_UNIQUE = -36,
        MA_NOT_SOCKET = -37,
        MA_NO_ADDRESS = -38,
        MA_BAD_PROTOCOL = -39,
        MA_PROTOCOL_UNAVAILABLE = -40,
        MA_PROTOCOL_NOT_SUPPORTED = -41,
        MA_PROTOCOL_FAMILY_NOT_SUPPORTED = -42,
        MA_ADDRESS_FAMILY_NOT_SUPPORTED = -43,
        MA_SOCKET_NOT_SUPPORTED = -44,
        MA_CONNECTION_RESET = -45,
        MA_ALREADY_CONNECTED = -46,
        MA_NOT_CONNECTED = -47,
        MA_CONNECTION_REFUSED = -48,
        MA_NO_HOST = -49,
        MA_IN_PROGRESS = -50,
        MA_CANCELLED = -51,
        MA_MEMORY_ALREADY_MAPPED = -52,
        MA_CRC_MISMATCH = -100,
        MA_FORMAT_NOT_SUPPORTED = -200,
        MA_DEVICE_TYPE_NOT_SUPPORTED = -201,
        MA_SHARE_MODE_NOT_SUPPORTED = -202,
        MA_NO_BACKEND = -203,
        MA_NO_DEVICE = -204,
        MA_API_NOT_FOUND = -205,
        MA_INVALID_DEVICE_CONFIG = -206,
        MA_LOOP = -207,
        MA_BACKEND_NOT_ENABLED = -208,
        MA_DEVICE_NOT_INITIALIZED = -300,
        MA_DEVICE_ALREADY_INITIALIZED = -301,
        MA_DEVICE_NOT_STARTED = -302,
        MA_DEVICE_NOT_STOPPED = -303,
        MA_FAILED_TO_INIT_BACKEND = -400,
        MA_FAILED_TO_OPEN_BACKEND_DEVICE = -401,
        MA_FAILED_TO_START_BACKEND_DEVICE = -402,
        MA_FAILED_TO_STOP_BACKEND_DEVICE = -403,
    }

    public enum ma_stream_format
    {
        ma_stream_format_pcm = 0,
    }

    public enum ma_stream_layout
    {
        ma_stream_layout_interleaved = 0,
        ma_stream_layout_deinterleaved = 1,
    }

    public enum ma_dither_mode
    {
        ma_dither_mode_none = 0,
        ma_dither_mode_rectangle = 1,
        ma_dither_mode_triangle = 2,
    }

    public enum ma_format
    {
        ma_format_unknown = 0,
        ma_format_u8 = 1,
        ma_format_s16 = 2,
        ma_format_s24 = 3,
        ma_format_s32 = 4,
        ma_format_f32 = 5,
        ma_format_count = 6,
    }

    public enum ma_standard_sample_rate
    {
        ma_standard_sample_rate_48000 = 48000,
        ma_standard_sample_rate_44100 = 44100,
        ma_standard_sample_rate_32000 = 32000,
        ma_standard_sample_rate_24000 = 24000,
        ma_standard_sample_rate_22050 = 22050,
        ma_standard_sample_rate_88200 = 88200,
        ma_standard_sample_rate_96000 = 96000,
        ma_standard_sample_rate_176400 = 176400,
        ma_standard_sample_rate_192000 = 192000,
        ma_standard_sample_rate_16000 = 16000,
        ma_standard_sample_rate_11025 = 11025,
        ma_standard_sample_rate_8000 = 8000,
        ma_standard_sample_rate_352800 = 352800,
        ma_standard_sample_rate_384000 = 384000,
        ma_standard_sample_rate_min = 8000,
        ma_standard_sample_rate_max = 384000,
        ma_standard_sample_rate_count = 14,
    }

    public enum ma_channel_mix_mode
    {
        ma_channel_mix_mode_rectangular = 0,
        ma_channel_mix_mode_simple = 1,
        ma_channel_mix_mode_custom_weights = 2,
        ma_channel_mix_mode_default = 0,
    }

    public enum ma_standard_channel_map
    {
        ma_standard_channel_map_microsoft = 0,
        ma_standard_channel_map_alsa = 1,
        ma_standard_channel_map_rfc3551 = 2,
        ma_standard_channel_map_flac = 3,
        ma_standard_channel_map_vorbis = 4,
        ma_standard_channel_map_sound4 = 5,
        ma_standard_channel_map_sndio = 6,
        ma_standard_channel_map_webaudio = 3,
        ma_standard_channel_map_default = 0,
    }

    public enum ma_performance_profile
    {
        ma_performance_profile_low_latency = 0,
        ma_performance_profile_conservative = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_allocation_callbacks
    {
        public IntPtr pUserData;
        public IntPtr onMalloc; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onRealloc; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onFree; // WARN_ANONYMOUS_FUNCTION_POINTER
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lcg
    {
        public uint state;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_atomic_uint32
    {
        public uint value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_atomic_int32
    {
        public int value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_atomic_uint64
    {
        public ulong value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_atomic_float
    {
        public float value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_atomic_bool32
    {
        public uint value;
    }

    public enum ma_thread_priority
    {
        ma_thread_priority_idle = -5,
        ma_thread_priority_lowest = -4,
        ma_thread_priority_low = -3,
        ma_thread_priority_normal = -2,
        ma_thread_priority_high = -1,
        ma_thread_priority_highest = 0,
        ma_thread_priority_realtime = 1,
        ma_thread_priority_default = 0,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_event
    {
        public uint value;
        public IntPtr @lock;
        public pthread_cond_t cond;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_semaphore
    {
        public int value;
        public IntPtr @lock;
        public pthread_cond_t cond;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_version(ref uint pMajor, ref uint pMinor, ref uint pRevision); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_version_string(); // WARN_UNKNOWN_POINTER_PARAMETER

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ma_log_callback_proc(void* pUserData, uint level, sbyte* pMessage);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_log_callback
    {
        public IntPtr onLog; // ma_log_callback_proc
        public IntPtr pUserData;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_log_callback ma_log_callback_init(ma_log_callback_proc onLog, IntPtr pUserData);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_log
    {
        public ma_log_callback__InlineArray callbacks;
        [InlineArray(4)]
        public partial struct ma_log_callback__InlineArray
        {
            public ma_log_callback _value;
        }

        public uint callbackCount;
        public ma_allocation_callbacks allocationCallbacks;
        public IntPtr @lock;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_log_init(ref ma_allocation_callbacks pAllocationCallbacks, ref ma_log pLog); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_log_uninit(ref ma_log pLog); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_log_register_callback(ref ma_log pLog, ma_log_callback callback); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_log_unregister_callback(ref ma_log pLog, ma_log_callback callback); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_log_post(ref ma_log pLog, uint level, IntPtr pMessage); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_log_postf(ref ma_log pLog, uint level, IntPtr pFormat); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Explicit)]
    public struct ma_biquad_coefficient
    {
        [FieldOffset(0)]
        public float f32;
        [FieldOffset(0)]
        public int s32;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_biquad_config
    {
        public ma_format format;
        public uint channels;
        public double b0;
        public double b1;
        public double b2;
        public double a0;
        public double a1;
        public double a2;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_biquad_config ma_biquad_config_init(ma_format format, uint channels, double b0, double b1, double b2, double a0, double a1, double a2);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_biquad
    {
        public ma_format format;
        public uint channels;
        [StructLayout(LayoutKind.Explicit)]
        public struct b0
        {
            [FieldOffset(0)]
            public float f32;
            [FieldOffset(0)]
            public int s32;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct b1
        {
            [FieldOffset(0)]
            public float f32;
            [FieldOffset(0)]
            public int s32;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct b2
        {
            [FieldOffset(0)]
            public float f32;
            [FieldOffset(0)]
            public int s32;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct a1
        {
            [FieldOffset(0)]
            public float f32;
            [FieldOffset(0)]
            public int s32;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct a2
        {
            [FieldOffset(0)]
            public float f32;
            [FieldOffset(0)]
            public int s32;
        }


        public * pR1;
        public * pR2;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_biquad_get_heap_size(ref ma_biquad_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_biquad_init_preallocated(ref ma_biquad_config pConfig, IntPtr pHeap, ref ma_biquad pBQ); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_biquad_init(ref ma_biquad_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_biquad pBQ); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_biquad_uninit(ref ma_biquad pBQ, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_biquad_reinit(ref ma_biquad_config pConfig, ref ma_biquad pBQ); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_biquad_clear_cache(ref ma_biquad pBQ); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_biquad_process_pcm_frames(ref ma_biquad pBQ, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_biquad_get_latency(ref ma_biquad pBQ); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lpf1_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double cutoffFrequency;
        public double q;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lpf2_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double cutoffFrequency;
        public double q;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_lpf1_config ma_lpf1_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_lpf1_config ma_lpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lpf1
    {
        public ma_format format;
        public uint channels;
        [StructLayout(LayoutKind.Explicit)]
        public struct a
        {
            [FieldOffset(0)]
            public float f32;
            [FieldOffset(0)]
            public int s32;
        }


        public * pR1;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf1_get_heap_size(ref ma_lpf1_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf1_init_preallocated(ref ma_lpf1_config pConfig, IntPtr pHeap, ref ma_lpf1 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf1_init(ref ma_lpf1_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_lpf1 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_lpf1_uninit(ref ma_lpf1 pLPF, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf1_reinit(ref ma_lpf1_config pConfig, ref ma_lpf1 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf1_clear_cache(ref ma_lpf1 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf1_process_pcm_frames(ref ma_lpf1 pLPF, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_lpf1_get_latency(ref ma_lpf1 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lpf2
    {
        public ma_biquad bq;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf2_get_heap_size(ref ma_lpf1_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf2_init_preallocated(ref ma_lpf1_config pConfig, IntPtr pHeap, ref ma_lpf2 pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf2_init(ref ma_lpf1_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_lpf2 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_lpf2_uninit(ref ma_lpf2 pLPF, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf2_reinit(ref ma_lpf1_config pConfig, ref ma_lpf2 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf2_clear_cache(ref ma_lpf2 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf2_process_pcm_frames(ref ma_lpf2 pLPF, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_lpf2_get_latency(ref ma_lpf2 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lpf_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double cutoffFrequency;
        public uint order;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_lpf_config ma_lpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lpf
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public uint lpf1Count;
        public uint lpf2Count;
        public ma_lpf1* pLPF1;
        public ma_lpf2* pLPF2;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf_get_heap_size(ref ma_lpf_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf_init_preallocated(ref ma_lpf_config pConfig, IntPtr pHeap, ref ma_lpf pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf_init(ref ma_lpf_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_lpf pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_lpf_uninit(ref ma_lpf pLPF, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf_reinit(ref ma_lpf_config pConfig, ref ma_lpf pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf_clear_cache(ref ma_lpf pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf_process_pcm_frames(ref ma_lpf pLPF, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_lpf_get_latency(ref ma_lpf pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hpf1_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double cutoffFrequency;
        public double q;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hpf2_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double cutoffFrequency;
        public double q;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_hpf1_config ma_hpf1_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_hpf1_config ma_hpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hpf1
    {
        public ma_format format;
        public uint channels;
        [StructLayout(LayoutKind.Explicit)]
        public struct a
        {
            [FieldOffset(0)]
            public float f32;
            [FieldOffset(0)]
            public int s32;
        }


        public * pR1;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf1_get_heap_size(ref ma_hpf1_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf1_init_preallocated(ref ma_hpf1_config pConfig, IntPtr pHeap, ref ma_hpf1 pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf1_init(ref ma_hpf1_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_hpf1 pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_hpf1_uninit(ref ma_hpf1 pHPF, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf1_reinit(ref ma_hpf1_config pConfig, ref ma_hpf1 pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf1_process_pcm_frames(ref ma_hpf1 pHPF, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_hpf1_get_latency(ref ma_hpf1 pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hpf2
    {
        public ma_biquad bq;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf2_get_heap_size(ref ma_hpf1_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf2_init_preallocated(ref ma_hpf1_config pConfig, IntPtr pHeap, ref ma_hpf2 pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf2_init(ref ma_hpf1_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_hpf2 pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_hpf2_uninit(ref ma_hpf2 pHPF, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf2_reinit(ref ma_hpf1_config pConfig, ref ma_hpf2 pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf2_process_pcm_frames(ref ma_hpf2 pHPF, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_hpf2_get_latency(ref ma_hpf2 pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hpf_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double cutoffFrequency;
        public uint order;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_hpf_config ma_hpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hpf
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public uint hpf1Count;
        public uint hpf2Count;
        public ma_hpf1* pHPF1;
        public ma_hpf2* pHPF2;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf_get_heap_size(ref ma_hpf_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf_init_preallocated(ref ma_hpf_config pConfig, IntPtr pHeap, ref ma_hpf pLPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf_init(ref ma_hpf_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_hpf pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_hpf_uninit(ref ma_hpf pHPF, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf_reinit(ref ma_hpf_config pConfig, ref ma_hpf pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf_process_pcm_frames(ref ma_hpf pHPF, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_hpf_get_latency(ref ma_hpf pHPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_bpf2_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double cutoffFrequency;
        public double q;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_bpf2_config ma_bpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_bpf2
    {
        public ma_biquad bq;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf2_get_heap_size(ref ma_bpf2_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf2_init_preallocated(ref ma_bpf2_config pConfig, IntPtr pHeap, ref ma_bpf2 pBPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf2_init(ref ma_bpf2_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_bpf2 pBPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_bpf2_uninit(ref ma_bpf2 pBPF, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf2_reinit(ref ma_bpf2_config pConfig, ref ma_bpf2 pBPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf2_process_pcm_frames(ref ma_bpf2 pBPF, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_bpf2_get_latency(ref ma_bpf2 pBPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_bpf_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double cutoffFrequency;
        public uint order;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_bpf_config ma_bpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_bpf
    {
        public ma_format format;
        public uint channels;
        public uint bpf2Count;
        public ma_bpf2* pBPF2;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf_get_heap_size(ref ma_bpf_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf_init_preallocated(ref ma_bpf_config pConfig, IntPtr pHeap, ref ma_bpf pBPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf_init(ref ma_bpf_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_bpf pBPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_bpf_uninit(ref ma_bpf pBPF, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf_reinit(ref ma_bpf_config pConfig, ref ma_bpf pBPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf_process_pcm_frames(ref ma_bpf pBPF, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_bpf_get_latency(ref ma_bpf pBPF); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_notch2_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double q;
        public double frequency;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_notch_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double q;
        public double frequency;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_notch2_config ma_notch2_config_init(ma_format format, uint channels, uint sampleRate, double q, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_notch2
    {
        public ma_biquad bq;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_notch2_get_heap_size(ref ma_notch2_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_notch2_init_preallocated(ref ma_notch2_config pConfig, IntPtr pHeap, ref ma_notch2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_notch2_init(ref ma_notch2_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_notch2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_notch2_uninit(ref ma_notch2 pFilter, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_notch2_reinit(ref ma_notch2_config pConfig, ref ma_notch2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_notch2_process_pcm_frames(ref ma_notch2 pFilter, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_notch2_get_latency(ref ma_notch2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_peak2_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double gainDB;
        public double q;
        public double frequency;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_peak_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double gainDB;
        public double q;
        public double frequency;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_peak2_config ma_peak2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double q, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_peak2
    {
        public ma_biquad bq;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_peak2_get_heap_size(ref ma_peak2_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_peak2_init_preallocated(ref ma_peak2_config pConfig, IntPtr pHeap, ref ma_peak2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_peak2_init(ref ma_peak2_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_peak2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_peak2_uninit(ref ma_peak2 pFilter, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_peak2_reinit(ref ma_peak2_config pConfig, ref ma_peak2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_peak2_process_pcm_frames(ref ma_peak2 pFilter, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_peak2_get_latency(ref ma_peak2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_loshelf2_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double gainDB;
        public double shelfSlope;
        public double frequency;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_loshelf_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double gainDB;
        public double shelfSlope;
        public double frequency;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_loshelf2_config ma_loshelf2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double shelfSlope, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_loshelf2
    {
        public ma_biquad bq;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_loshelf2_get_heap_size(ref ma_loshelf2_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_loshelf2_init_preallocated(ref ma_loshelf2_config pConfig, IntPtr pHeap, ref ma_loshelf2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_loshelf2_init(ref ma_loshelf2_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_loshelf2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_loshelf2_uninit(ref ma_loshelf2 pFilter, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_loshelf2_reinit(ref ma_loshelf2_config pConfig, ref ma_loshelf2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_loshelf2_process_pcm_frames(ref ma_loshelf2 pFilter, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_loshelf2_get_latency(ref ma_loshelf2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hishelf2_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double gainDB;
        public double shelfSlope;
        public double frequency;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hishelf_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double gainDB;
        public double shelfSlope;
        public double frequency;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_hishelf2_config ma_hishelf2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double shelfSlope, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hishelf2
    {
        public ma_biquad bq;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hishelf2_get_heap_size(ref ma_hishelf2_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hishelf2_init_preallocated(ref ma_hishelf2_config pConfig, IntPtr pHeap, ref ma_hishelf2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hishelf2_init(ref ma_hishelf2_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_hishelf2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_hishelf2_uninit(ref ma_hishelf2 pFilter, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hishelf2_reinit(ref ma_hishelf2_config pConfig, ref ma_hishelf2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hishelf2_process_pcm_frames(ref ma_hishelf2 pFilter, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_hishelf2_get_latency(ref ma_hishelf2 pFilter); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_delay_config
    {
        public uint channels;
        public uint sampleRate;
        public uint delayInFrames;
        public uint delayStart;
        public float wet;
        public float dry;
        public float decay;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_delay_config ma_delay_config_init(uint channels, uint sampleRate, uint delayInFrames, float decay);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_delay
    {
        public ma_delay_config config;
        public uint cursor;
        public uint bufferSizeInFrames;
        public float* pBuffer;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_delay_init(ref ma_delay_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_delay pDelay); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_delay_uninit(ref ma_delay pDelay, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_delay_process_pcm_frames(ref ma_delay pDelay, IntPtr pFramesOut, IntPtr pFramesIn, uint frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_delay_set_wet(ref ma_delay pDelay, float value); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_delay_get_wet(ref ma_delay pDelay); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_delay_set_dry(ref ma_delay pDelay, float value); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_delay_get_dry(ref ma_delay pDelay); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_delay_set_decay(ref ma_delay pDelay, float value); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_delay_get_decay(ref ma_delay pDelay); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_gainer_config
    {
        public uint channels;
        public uint smoothTimeInFrames;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_gainer_config ma_gainer_config_init(uint channels, uint smoothTimeInFrames);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_gainer
    {
        public ma_gainer_config config;
        public uint t;
        public float masterVolume;
        public float* pOldGains;
        public float* pNewGains;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_gainer_get_heap_size(ref ma_gainer_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_gainer_init_preallocated(ref ma_gainer_config pConfig, IntPtr pHeap, ref ma_gainer pGainer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_gainer_init(ref ma_gainer_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_gainer pGainer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_gainer_uninit(ref ma_gainer pGainer, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_gainer_process_pcm_frames(ref ma_gainer pGainer, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_gainer_set_gain(ref ma_gainer pGainer, float newGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_gainer_set_gains(ref ma_gainer pGainer, IntPtr pNewGains); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_gainer_set_master_volume(ref ma_gainer pGainer, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_gainer_get_master_volume(ref ma_gainer pGainer, IntPtr pVolume); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_pan_mode
    {
        ma_pan_mode_balance = 0,
        ma_pan_mode_pan = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_panner_config
    {
        public ma_format format;
        public uint channels;
        public ma_pan_mode mode;
        public float pan;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_panner_config ma_panner_config_init(ma_format format, uint channels);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_panner
    {
        public ma_format format;
        public uint channels;
        public ma_pan_mode mode;
        public float pan;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_panner_init(ref ma_panner_config pConfig, ref ma_panner pPanner); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_panner_process_pcm_frames(ref ma_panner pPanner, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_panner_set_mode(ref ma_panner pPanner, ma_pan_mode mode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_pan_mode ma_panner_get_mode(ref ma_panner pPanner); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_panner_set_pan(ref ma_panner pPanner, float pan); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_panner_get_pan(ref ma_panner pPanner); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_fader_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_fader_config ma_fader_config_init(ma_format format, uint channels, uint sampleRate);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_fader
    {
        public ma_fader_config config;
        public float volumeBeg;
        public float volumeEnd;
        public ulong lengthInFrames;
        public long cursorInFrames;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_fader_init(ref ma_fader_config pConfig, ref ma_fader pFader); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_fader_process_pcm_frames(ref ma_fader pFader, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_fader_get_data_format(ref ma_fader pFader, IntPtr pFormat, ref uint pChannels, ref uint pSampleRate); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_fader_set_fade(ref ma_fader pFader, float volumeBeg, float volumeEnd, ulong lengthInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_fader_set_fade_ex(ref ma_fader pFader, float volumeBeg, float volumeEnd, ulong lengthInFrames, long startOffsetInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_fader_get_current_volume(ref ma_fader pFader); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_vec3f
    {
        public float x;
        public float y;
        public float z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_atomic_vec3f
    {
        public ma_vec3f v;
        public uint @lock;
    }

    public enum ma_attenuation_model
    {
        ma_attenuation_model_none = 0,
        ma_attenuation_model_inverse = 1,
        ma_attenuation_model_linear = 2,
        ma_attenuation_model_exponential = 3,
    }

    public enum ma_positioning
    {
        ma_positioning_absolute = 0,
        ma_positioning_relative = 1,
    }

    public enum ma_handedness
    {
        ma_handedness_right = 0,
        ma_handedness_left = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_spatializer_listener_config
    {
        public uint channelsOut;
        public byte* pChannelMapOut;
        public ma_handedness handedness;
        public float coneInnerAngleInRadians;
        public float coneOuterAngleInRadians;
        public float coneOuterGain;
        public float speedOfSound;
        public ma_vec3f worldUp;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_spatializer_listener_config ma_spatializer_listener_config_init(uint channelsOut);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_spatializer_listener
    {
        public ma_spatializer_listener_config config;
        public ma_atomic_vec3f position;
        public ma_atomic_vec3f direction;
        public ma_atomic_vec3f velocity;
        public uint isEnabled;
        public uint _ownsHeap;
        public IntPtr _pHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_listener_get_heap_size(ref ma_spatializer_listener_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_listener_init_preallocated(ref ma_spatializer_listener_config pConfig, IntPtr pHeap, ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_listener_init(ref ma_spatializer_listener_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_uninit(ref ma_spatializer_listener pListener, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial byte* ma_spatializer_listener_get_channel_map(ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_set_cone(ref ma_spatializer_listener pListener, float innerAngleInRadians, float outerAngleInRadians, float outerGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_get_cone(ref ma_spatializer_listener pListener, IntPtr pInnerAngleInRadians, IntPtr pOuterAngleInRadians, IntPtr pOuterGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_set_position(ref ma_spatializer_listener pListener, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_spatializer_listener_get_position(ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_set_direction(ref ma_spatializer_listener pListener, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_spatializer_listener_get_direction(ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_set_velocity(ref ma_spatializer_listener pListener, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_spatializer_listener_get_velocity(ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_set_speed_of_sound(ref ma_spatializer_listener pListener, float speedOfSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_spatializer_listener_get_speed_of_sound(ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_set_world_up(ref ma_spatializer_listener pListener, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_spatializer_listener_get_world_up(ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_listener_set_enabled(ref ma_spatializer_listener pListener, uint isEnabled); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_spatializer_listener_is_enabled(ref ma_spatializer_listener pListener); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_spatializer_config
    {
        public uint channelsIn;
        public uint channelsOut;
        public byte* pChannelMapIn;
        public ma_attenuation_model attenuationModel;
        public ma_positioning positioning;
        public ma_handedness handedness;
        public float minGain;
        public float maxGain;
        public float minDistance;
        public float maxDistance;
        public float rolloff;
        public float coneInnerAngleInRadians;
        public float coneOuterAngleInRadians;
        public float coneOuterGain;
        public float dopplerFactor;
        public float directionalAttenuationFactor;
        public float minSpatializationChannelGain;
        public uint gainSmoothTimeInFrames;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_spatializer_config ma_spatializer_config_init(uint channelsIn, uint channelsOut);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_spatializer
    {
        public uint channelsIn;
        public uint channelsOut;
        public byte* pChannelMapIn;
        public ma_attenuation_model attenuationModel;
        public ma_positioning positioning;
        public ma_handedness handedness;
        public float minGain;
        public float maxGain;
        public float minDistance;
        public float maxDistance;
        public float rolloff;
        public float coneInnerAngleInRadians;
        public float coneOuterAngleInRadians;
        public float coneOuterGain;
        public float dopplerFactor;
        public float directionalAttenuationFactor;
        public uint gainSmoothTimeInFrames;
        public ma_atomic_vec3f position;
        public ma_atomic_vec3f direction;
        public ma_atomic_vec3f velocity;
        public float dopplerPitch;
        public float minSpatializationChannelGain;
        public ma_gainer gainer;
        public float* pNewChannelGainsOut;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_get_heap_size(ref ma_spatializer_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_init_preallocated(ref ma_spatializer_config pConfig, IntPtr pHeap, ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_init(ref ma_spatializer_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_uninit(ref ma_spatializer pSpatializer, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_process_pcm_frames(ref ma_spatializer pSpatializer, ref ma_spatializer_listener pListener, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_set_master_volume(ref ma_spatializer pSpatializer, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spatializer_get_master_volume(ref ma_spatializer pSpatializer, IntPtr pVolume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_spatializer_get_input_channels(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_spatializer_get_output_channels(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_attenuation_model(ref ma_spatializer pSpatializer, ma_attenuation_model attenuationModel); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_attenuation_model ma_spatializer_get_attenuation_model(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_positioning(ref ma_spatializer pSpatializer, ma_positioning positioning); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_positioning ma_spatializer_get_positioning(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_rolloff(ref ma_spatializer pSpatializer, float rolloff); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_spatializer_get_rolloff(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_min_gain(ref ma_spatializer pSpatializer, float minGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_spatializer_get_min_gain(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_max_gain(ref ma_spatializer pSpatializer, float maxGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_spatializer_get_max_gain(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_min_distance(ref ma_spatializer pSpatializer, float minDistance); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_spatializer_get_min_distance(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_max_distance(ref ma_spatializer pSpatializer, float maxDistance); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_spatializer_get_max_distance(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_cone(ref ma_spatializer pSpatializer, float innerAngleInRadians, float outerAngleInRadians, float outerGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_get_cone(ref ma_spatializer pSpatializer, IntPtr pInnerAngleInRadians, IntPtr pOuterAngleInRadians, IntPtr pOuterGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_doppler_factor(ref ma_spatializer pSpatializer, float dopplerFactor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_spatializer_get_doppler_factor(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_directional_attenuation_factor(ref ma_spatializer pSpatializer, float directionalAttenuationFactor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_spatializer_get_directional_attenuation_factor(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_position(ref ma_spatializer pSpatializer, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_spatializer_get_position(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_direction(ref ma_spatializer pSpatializer, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_spatializer_get_direction(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_set_velocity(ref ma_spatializer pSpatializer, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_spatializer_get_velocity(ref ma_spatializer pSpatializer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_spatializer_get_relative_position_and_direction(ref ma_spatializer pSpatializer, ref ma_spatializer_listener pListener, ref ma_vec3f pRelativePos, ref ma_vec3f pRelativeDir); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_linear_resampler_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRateIn;
        public uint sampleRateOut;
        public uint lpfOrder;
        public double lpfNyquistFactor;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_linear_resampler_config ma_linear_resampler_config_init(ma_format format, uint channels, uint sampleRateIn, uint sampleRateOut);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_linear_resampler
    {
        public ma_linear_resampler_config config;
        public uint inAdvanceInt;
        public uint inAdvanceFrac;
        public uint inTimeInt;
        public uint inTimeFrac;
        [StructLayout(LayoutKind.Explicit)]
        public struct x0
        {
            [FieldOffset(0)]
            public float* f32;
            [FieldOffset(0)]
            public short* s16;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct x1
        {
            [FieldOffset(0)]
            public float* f32;
            [FieldOffset(0)]
            public short* s16;
        }


        public ma_lpf lpf;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_get_heap_size(ref ma_linear_resampler_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_init_preallocated(ref ma_linear_resampler_config pConfig, IntPtr pHeap, ref ma_linear_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_init(ref ma_linear_resampler_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_linear_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_linear_resampler_uninit(ref ma_linear_resampler pResampler, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_process_pcm_frames(ref ma_linear_resampler pResampler, IntPtr pFramesIn, ref ulong pFrameCountIn, IntPtr pFramesOut, ref ulong pFrameCountOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_set_rate(ref ma_linear_resampler pResampler, uint sampleRateIn, uint sampleRateOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_set_rate_ratio(ref ma_linear_resampler pResampler, float ratioInOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_linear_resampler_get_input_latency(ref ma_linear_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_linear_resampler_get_output_latency(ref ma_linear_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_get_required_input_frame_count(ref ma_linear_resampler pResampler, ulong outputFrameCount, ref ulong pInputFrameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_get_expected_output_frame_count(ref ma_linear_resampler pResampler, ulong inputFrameCount, ref ulong pOutputFrameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_linear_resampler_reset(ref ma_linear_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resampling_backend_vtable
    {
        public IntPtr onGetHeapSize; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onInit; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onUninit; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onProcess; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onSetRate; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onGetInputLatency; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onGetOutputLatency; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onGetRequiredInputFrameCount; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onGetExpectedOutputFrameCount; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onReset; // WARN_ANONYMOUS_FUNCTION_POINTER
    }

    public enum ma_resample_algorithm
    {
        ma_resample_algorithm_linear = 0,
        ma_resample_algorithm_custom = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resampler_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRateIn;
        public uint sampleRateOut;
        public ma_resample_algorithm algorithm;
        public ma_resampling_backend_vtable* pBackendVTable;
        public IntPtr pBackendUserData;
        [StructLayout(LayoutKind.Sequential)]
        public struct linear
        {
            public uint lpfOrder;
        }


    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_resampler_config ma_resampler_config_init(ma_format format, uint channels, uint sampleRateIn, uint sampleRateOut, ma_resample_algorithm algorithm);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resampler
    {
        public IntPtr pBackend;
        public ma_resampling_backend_vtable* pBackendVTable;
        public IntPtr pBackendUserData;
        public ma_format format;
        public uint channels;
        public uint sampleRateIn;
        public uint sampleRateOut;
        [StructLayout(LayoutKind.Explicit)]
        public struct state
        {
            [FieldOffset(0)]
            public ma_linear_resampler linear;
        }


        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_get_heap_size(IntPtr pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_init_preallocated(IntPtr pConfig, IntPtr pHeap, ref ma_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_init(IntPtr pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_resampler_uninit(ref ma_resampler pResampler, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_process_pcm_frames(ref ma_resampler pResampler, IntPtr pFramesIn, ref ulong pFrameCountIn, IntPtr pFramesOut, ref ulong pFrameCountOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_set_rate(ref ma_resampler pResampler, uint sampleRateIn, uint sampleRateOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_set_rate_ratio(ref ma_resampler pResampler, float ratio); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_resampler_get_input_latency(ref ma_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_resampler_get_output_latency(ref ma_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_get_required_input_frame_count(ref ma_resampler pResampler, ulong outputFrameCount, ref ulong pInputFrameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_get_expected_output_frame_count(ref ma_resampler pResampler, ulong inputFrameCount, ref ulong pOutputFrameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resampler_reset(ref ma_resampler pResampler); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_channel_conversion_path
    {
        ma_channel_conversion_path_unknown = 0,
        ma_channel_conversion_path_passthrough = 1,
        ma_channel_conversion_path_mono_out = 2,
        ma_channel_conversion_path_mono_in = 3,
        ma_channel_conversion_path_shuffle = 4,
        ma_channel_conversion_path_weights = 5,
    }

    public enum ma_mono_expansion_mode
    {
        ma_mono_expansion_mode_duplicate = 0,
        ma_mono_expansion_mode_average = 1,
        ma_mono_expansion_mode_stereo_only = 2,
        ma_mono_expansion_mode_default = 0,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_channel_converter_config
    {
        public ma_format format;
        public uint channelsIn;
        public uint channelsOut;
        public byte* pChannelMapIn;
        public byte* pChannelMapOut;
        public ma_channel_mix_mode mixingMode;
        public uint calculateLFEFromSpatialChannels;
        public float** ppWeights;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_channel_converter_config ma_channel_converter_config_init(ma_format format, uint channelsIn, ref byte pChannelMapIn, uint channelsOut, ref byte pChannelMapOut, ma_channel_mix_mode mixingMode); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_channel_converter
    {
        public ma_format format;
        public uint channelsIn;
        public uint channelsOut;
        public ma_channel_mix_mode mixingMode;
        public ma_channel_conversion_path conversionPath;
        public byte* pChannelMapIn;
        public byte* pChannelMapOut;
        public byte* pShuffleTable;
        [StructLayout(LayoutKind.Explicit)]
        public struct weights
        {
            [FieldOffset(0)]
            public float** f32;
            [FieldOffset(0)]
            public int** s16;
        }


        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_channel_converter_get_heap_size(ref ma_channel_converter_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_channel_converter_init_preallocated(ref ma_channel_converter_config pConfig, IntPtr pHeap, ref ma_channel_converter pConverter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_channel_converter_init(ref ma_channel_converter_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_channel_converter pConverter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_channel_converter_uninit(ref ma_channel_converter pConverter, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_channel_converter_process_pcm_frames(ref ma_channel_converter pConverter, IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_channel_converter_get_input_channel_map(ref ma_channel_converter pConverter, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_channel_converter_get_output_channel_map(ref ma_channel_converter pConverter, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_data_converter_config
    {
        public ma_format formatIn;
        public ma_format formatOut;
        public uint channelsIn;
        public uint channelsOut;
        public uint sampleRateIn;
        public uint sampleRateOut;
        public byte* pChannelMapIn;
        public byte* pChannelMapOut;
        public ma_dither_mode ditherMode;
        public ma_channel_mix_mode channelMixMode;
        public uint calculateLFEFromSpatialChannels;
        public float** ppChannelWeights;
        public uint allowDynamicSampleRate;
        public ma_resampler_config resampling;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_data_converter_config ma_data_converter_config_init_default();

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_data_converter_config ma_data_converter_config_init(ma_format formatIn, ma_format formatOut, uint channelsIn, uint channelsOut, uint sampleRateIn, uint sampleRateOut);

    public enum ma_data_converter_execution_path
    {
        ma_data_converter_execution_path_passthrough = 0,
        ma_data_converter_execution_path_format_only = 1,
        ma_data_converter_execution_path_channels_only = 2,
        ma_data_converter_execution_path_resample_only = 3,
        ma_data_converter_execution_path_resample_first = 4,
        ma_data_converter_execution_path_channels_first = 5,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_data_converter
    {
        public ma_format formatIn;
        public ma_format formatOut;
        public uint channelsIn;
        public uint channelsOut;
        public uint sampleRateIn;
        public uint sampleRateOut;
        public ma_dither_mode ditherMode;
        public ma_data_converter_execution_path executionPath;
        public ma_channel_converter channelConverter;
        public ma_resampler resampler;
        public byte hasPreFormatConversion;
        public byte hasPostFormatConversion;
        public byte hasChannelConverter;
        public byte hasResampler;
        public byte isPassthrough;
        public byte _ownsHeap;
        public IntPtr _pHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_get_heap_size(ref ma_data_converter_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_init_preallocated(ref ma_data_converter_config pConfig, IntPtr pHeap, ref ma_data_converter pConverter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_init(ref ma_data_converter_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_data_converter pConverter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_data_converter_uninit(ref ma_data_converter pConverter, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_process_pcm_frames(ref ma_data_converter pConverter, IntPtr pFramesIn, ref ulong pFrameCountIn, IntPtr pFramesOut, ref ulong pFrameCountOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_set_rate(ref ma_data_converter pConverter, uint sampleRateIn, uint sampleRateOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_set_rate_ratio(ref ma_data_converter pConverter, float ratioInOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_data_converter_get_input_latency(ref ma_data_converter pConverter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_data_converter_get_output_latency(ref ma_data_converter pConverter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_get_required_input_frame_count(ref ma_data_converter pConverter, ulong outputFrameCount, ref ulong pInputFrameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_get_expected_output_frame_count(ref ma_data_converter pConverter, ulong inputFrameCount, ref ulong pOutputFrameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_get_input_channel_map(ref ma_data_converter pConverter, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_get_output_channel_map(ref ma_data_converter pConverter, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_converter_reset(ref ma_data_converter pConverter); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_u8_to_s16(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_u8_to_s24(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_u8_to_s32(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_u8_to_f32(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s16_to_u8(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s16_to_s24(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s16_to_s32(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s16_to_f32(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s24_to_u8(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s24_to_s16(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s24_to_s32(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s24_to_f32(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s32_to_u8(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s32_to_s16(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s32_to_s24(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_s32_to_f32(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_f32_to_u8(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_f32_to_s16(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_f32_to_s24(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_f32_to_s32(IntPtr pOut, IntPtr pIn, ulong count, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_convert(IntPtr pOut, ma_format formatOut, IntPtr pIn, ma_format formatIn, ulong sampleCount, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_convert_pcm_frames_format(IntPtr pOut, ma_format formatOut, IntPtr pIn, ma_format formatIn, ulong frameCount, uint channels, ma_dither_mode ditherMode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_deinterleave_pcm_frames(ma_format format, uint channels, ulong frameCount, IntPtr pInterleavedPCMFrames, IntPtr ppDeinterleavedPCMFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_interleave_pcm_frames(ma_format format, uint channels, ulong frameCount, IntPtr ppDeinterleavedPCMFrames, IntPtr pInterleavedPCMFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial byte ma_channel_map_get_channel(ref byte pChannelMap, uint channelCount, uint channelIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_channel_map_init_blank(ref byte pChannelMap, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_channel_map_init_standard(ma_standard_channel_map standardChannelMap, ref byte pChannelMap, UIntPtr channelMapCap, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_channel_map_copy(ref byte pOut, ref byte pIn, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_channel_map_copy_or_default(ref byte pOut, UIntPtr channelMapCapOut, ref byte pIn, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_channel_map_is_valid(ref byte pChannelMap, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_channel_map_is_equal(ref byte pChannelMapA, ref byte pChannelMapB, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_channel_map_is_blank(ref byte pChannelMap, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_channel_map_contains_channel_position(uint channels, ref byte pChannelMap, byte channelPosition); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_channel_map_find_channel_position(uint channels, ref byte pChannelMap, byte channelPosition, ref uint pChannelIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial UIntPtr ma_channel_map_to_string(ref byte pChannelMap, uint channels, IntPtr pBufferOut, UIntPtr bufferCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_channel_position_to_string(byte channel); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_convert_frames(IntPtr pOut, ulong frameCountOut, ma_format formatOut, uint channelsOut, uint sampleRateOut, IntPtr pIn, ulong frameCountIn, ma_format formatIn, uint channelsIn, uint sampleRateIn);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_convert_frames_ex(IntPtr pOut, ulong frameCountOut, IntPtr pIn, ulong frameCountIn, ref ma_data_converter_config pConfig); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_data_source_vtable
    {
        public IntPtr onRead; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onSeek; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onGetDataFormat; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onGetCursor; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onGetLength; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onSetLooping; // WARN_ANONYMOUS_FUNCTION_POINTER
        public uint flags;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* ma_data_source_get_next_proc(void* pDataSource);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_data_source_config
    {
        public ma_data_source_vtable* vtable;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_data_source_config ma_data_source_config_init();

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_data_source_base
    {
        public ma_data_source_vtable* vtable;
        public ulong rangeBegInFrames;
        public ulong rangeEndInFrames;
        public ulong loopBegInFrames;
        public ulong loopEndInFrames;
        public IntPtr pCurrent;
        public IntPtr pNext;
        public IntPtr onGetNext; // ma_data_source_get_next_proc
        public uint isLooping;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_init(ref ma_data_source_config pConfig, IntPtr pDataSource); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_data_source_uninit(IntPtr pDataSource);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_read_pcm_frames(IntPtr pDataSource, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_seek_pcm_frames(IntPtr pDataSource, ulong frameCount, ref ulong pFramesSeeked); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_seek_to_pcm_frame(IntPtr pDataSource, ulong frameIndex);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_seek_seconds(IntPtr pDataSource, float secondCount, IntPtr pSecondsSeeked); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_seek_to_second(IntPtr pDataSource, float seekPointInSeconds);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_get_data_format(IntPtr pDataSource, IntPtr pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_get_cursor_in_pcm_frames(IntPtr pDataSource, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_get_length_in_pcm_frames(IntPtr pDataSource, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_get_cursor_in_seconds(IntPtr pDataSource, IntPtr pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_get_length_in_seconds(IntPtr pDataSource, IntPtr pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_set_looping(IntPtr pDataSource, uint isLooping);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_data_source_is_looping(IntPtr pDataSource);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_set_range_in_pcm_frames(IntPtr pDataSource, ulong rangeBegInFrames, ulong rangeEndInFrames);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_data_source_get_range_in_pcm_frames(IntPtr pDataSource, ref ulong pRangeBegInFrames, ref ulong pRangeEndInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_set_loop_point_in_pcm_frames(IntPtr pDataSource, ulong loopBegInFrames, ulong loopEndInFrames);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_data_source_get_loop_point_in_pcm_frames(IntPtr pDataSource, ref ulong pLoopBegInFrames, ref ulong pLoopEndInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_set_current(IntPtr pDataSource, IntPtr pCurrentDataSource);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_data_source_get_current(IntPtr pDataSource);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_set_next(IntPtr pDataSource, IntPtr pNextDataSource);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_data_source_get_next(IntPtr pDataSource);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_set_next_callback(IntPtr pDataSource, ma_data_source_get_next_proc onGetNext);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_data_source_get_next_proc ma_data_source_get_next_callback(IntPtr pDataSource);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_audio_buffer_ref
    {
        public ma_data_source_base ds;
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public ulong cursor;
        public ulong sizeInFrames;
        public IntPtr pData;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_ref_init(ma_format format, uint channels, IntPtr pData, ulong sizeInFrames, ref ma_audio_buffer_ref pAudioBufferRef); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_audio_buffer_ref_uninit(ref ma_audio_buffer_ref pAudioBufferRef); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_ref_set_data(ref ma_audio_buffer_ref pAudioBufferRef, IntPtr pData, ulong sizeInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_audio_buffer_ref_read_pcm_frames(ref ma_audio_buffer_ref pAudioBufferRef, IntPtr pFramesOut, ulong frameCount, uint loop); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_ref_seek_to_pcm_frame(ref ma_audio_buffer_ref pAudioBufferRef, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_ref_map(ref ma_audio_buffer_ref pAudioBufferRef, IntPtr ppFramesOut, ref ulong pFrameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_ref_unmap(ref ma_audio_buffer_ref pAudioBufferRef, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_audio_buffer_ref_at_end(ref ma_audio_buffer_ref pAudioBufferRef); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_ref_get_cursor_in_pcm_frames(ref ma_audio_buffer_ref pAudioBufferRef, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_ref_get_length_in_pcm_frames(ref ma_audio_buffer_ref pAudioBufferRef, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_ref_get_available_frames(ref ma_audio_buffer_ref pAudioBufferRef, ref ulong pAvailableFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_audio_buffer_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public ulong sizeInFrames;
        public IntPtr pData;
        public ma_allocation_callbacks allocationCallbacks;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_audio_buffer_config ma_audio_buffer_config_init(ma_format format, uint channels, ulong sizeInFrames, IntPtr pData, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_audio_buffer
    {
        public ma_audio_buffer_ref @ref;
        public ma_allocation_callbacks allocationCallbacks;
        public uint ownsData;
        public fixed byte _pExtraData[1];
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_init(ref ma_audio_buffer_config pConfig, ref ma_audio_buffer pAudioBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_init_copy(ref ma_audio_buffer_config pConfig, ref ma_audio_buffer pAudioBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_alloc_and_init(ref ma_audio_buffer_config pConfig, IntPtr ppAudioBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_audio_buffer_uninit(ref ma_audio_buffer pAudioBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_audio_buffer_uninit_and_free(ref ma_audio_buffer pAudioBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_audio_buffer_read_pcm_frames(ref ma_audio_buffer pAudioBuffer, IntPtr pFramesOut, ulong frameCount, uint loop); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_seek_to_pcm_frame(ref ma_audio_buffer pAudioBuffer, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_map(ref ma_audio_buffer pAudioBuffer, IntPtr ppFramesOut, ref ulong pFrameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_unmap(ref ma_audio_buffer pAudioBuffer, ulong frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_audio_buffer_at_end(ref ma_audio_buffer pAudioBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_get_cursor_in_pcm_frames(ref ma_audio_buffer pAudioBuffer, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_get_length_in_pcm_frames(ref ma_audio_buffer pAudioBuffer, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_audio_buffer_get_available_frames(ref ma_audio_buffer pAudioBuffer, ref ulong pAvailableFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_paged_audio_buffer_page
    {
        public ma_paged_audio_buffer_page* pNext;
        public ulong sizeInFrames;
        public fixed byte pAudioData[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_paged_audio_buffer_data
    {
        public ma_format format;
        public uint channels;
        public ma_paged_audio_buffer_page head;
        public ma_paged_audio_buffer_page* pTail;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_data_init(ma_format format, uint channels, ref ma_paged_audio_buffer_data pData); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_paged_audio_buffer_data_uninit(ref ma_paged_audio_buffer_data pData, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_paged_audio_buffer_data_get_head(ref ma_paged_audio_buffer_data pData); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_paged_audio_buffer_data_get_tail(ref ma_paged_audio_buffer_data pData); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_data_get_length_in_pcm_frames(ref ma_paged_audio_buffer_data pData, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_data_allocate_page(ref ma_paged_audio_buffer_data pData, ulong pageSizeInFrames, IntPtr pInitialData, ref ma_allocation_callbacks pAllocationCallbacks, IntPtr ppPage); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_data_free_page(ref ma_paged_audio_buffer_data pData, IntPtr pPage, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_data_append_page(ref ma_paged_audio_buffer_data pData, IntPtr pPage); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_data_allocate_and_append_page(ref ma_paged_audio_buffer_data pData, uint pageSizeInFrames, IntPtr pInitialData, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_paged_audio_buffer_config
    {
        public ma_paged_audio_buffer_data* pData;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_paged_audio_buffer_config ma_paged_audio_buffer_config_init(ref ma_paged_audio_buffer_data pData); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_paged_audio_buffer
    {
        public ma_data_source_base ds;
        public ma_paged_audio_buffer_data* pData;
        public ma_paged_audio_buffer_page* pCurrent;
        public ulong relativeCursor;
        public ulong absoluteCursor;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_init(ref ma_paged_audio_buffer_config pConfig, ref ma_paged_audio_buffer pPagedAudioBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_paged_audio_buffer_uninit(ref ma_paged_audio_buffer pPagedAudioBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_read_pcm_frames(ref ma_paged_audio_buffer pPagedAudioBuffer, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_seek_to_pcm_frame(ref ma_paged_audio_buffer pPagedAudioBuffer, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_get_cursor_in_pcm_frames(ref ma_paged_audio_buffer pPagedAudioBuffer, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_paged_audio_buffer_get_length_in_pcm_frames(ref ma_paged_audio_buffer pPagedAudioBuffer, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_rb
    {
        public IntPtr pBuffer;
        public uint subbufferSizeInBytes;
        public uint subbufferCount;
        public uint subbufferStrideInBytes;
        public uint encodedReadOffset;
        public uint encodedWriteOffset;
        public byte ownsBuffer;
        public byte clearOnWriteAcquire;
        public ma_allocation_callbacks allocationCallbacks;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_rb_init_ex(UIntPtr subbufferSizeInBytes, UIntPtr subbufferCount, UIntPtr subbufferStrideInBytes, IntPtr pOptionalPreallocatedBuffer, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_rb_init(UIntPtr bufferSizeInBytes, IntPtr pOptionalPreallocatedBuffer, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_rb_uninit(ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_rb_reset(ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_rb_acquire_read(ref ma_rb pRB, IntPtr pSizeInBytes, IntPtr ppBufferOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_rb_commit_read(ref ma_rb pRB, UIntPtr sizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_rb_acquire_write(ref ma_rb pRB, IntPtr pSizeInBytes, IntPtr ppBufferOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_rb_commit_write(ref ma_rb pRB, UIntPtr sizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_rb_seek_read(ref ma_rb pRB, UIntPtr offsetInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_rb_seek_write(ref ma_rb pRB, UIntPtr offsetInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int ma_rb_pointer_distance(ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_rb_available_read(ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_rb_available_write(ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial UIntPtr ma_rb_get_subbuffer_size(ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial UIntPtr ma_rb_get_subbuffer_stride(ref ma_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial UIntPtr ma_rb_get_subbuffer_offset(ref ma_rb pRB, UIntPtr subbufferIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_rb_get_subbuffer_ptr(ref ma_rb pRB, UIntPtr subbufferIndex, IntPtr pBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_pcm_rb
    {
        public ma_data_source_base ds;
        public ma_rb rb;
        public ma_format format;
        public uint channels;
        public uint sampleRate;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pcm_rb_init_ex(ma_format format, uint channels, uint subbufferSizeInFrames, uint subbufferCount, uint subbufferStrideInFrames, IntPtr pOptionalPreallocatedBuffer, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pcm_rb_init(ma_format format, uint channels, uint bufferSizeInFrames, IntPtr pOptionalPreallocatedBuffer, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_rb_uninit(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_rb_reset(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pcm_rb_acquire_read(ref ma_pcm_rb pRB, ref uint pSizeInFrames, IntPtr ppBufferOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pcm_rb_commit_read(ref ma_pcm_rb pRB, uint sizeInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pcm_rb_acquire_write(ref ma_pcm_rb pRB, ref uint pSizeInFrames, IntPtr ppBufferOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pcm_rb_commit_write(ref ma_pcm_rb pRB, uint sizeInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pcm_rb_seek_read(ref ma_pcm_rb pRB, uint offsetInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pcm_rb_seek_write(ref ma_pcm_rb pRB, uint offsetInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int ma_pcm_rb_pointer_distance(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_pcm_rb_available_read(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_pcm_rb_available_write(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_pcm_rb_get_subbuffer_size(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_pcm_rb_get_subbuffer_stride(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_pcm_rb_get_subbuffer_offset(ref ma_pcm_rb pRB, uint subbufferIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_pcm_rb_get_subbuffer_ptr(ref ma_pcm_rb pRB, uint subbufferIndex, IntPtr pBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_format ma_pcm_rb_get_format(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_pcm_rb_get_channels(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_pcm_rb_get_sample_rate(ref ma_pcm_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pcm_rb_set_sample_rate(ref ma_pcm_rb pRB, uint sampleRate); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_duplex_rb
    {
        public ma_pcm_rb rb;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_duplex_rb_init(ma_format captureFormat, uint captureChannels, uint sampleRate, uint captureInternalSampleRate, uint captureInternalPeriodSizeInFrames, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_duplex_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_duplex_rb_uninit(ref ma_duplex_rb pRB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_result_description(ma_result result); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_malloc(UIntPtr sz, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_calloc(UIntPtr sz, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_realloc(IntPtr p, UIntPtr sz, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_free(IntPtr p, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_aligned_malloc(UIntPtr sz, UIntPtr alignment, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_aligned_free(IntPtr p, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_get_format_name(ma_format format); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_blend_f32(IntPtr pOut, IntPtr pInA, IntPtr pInB, float factor, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_get_bytes_per_sample(ma_format format);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_get_bytes_per_frame(ma_format format, uint channels);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_log_level_to_string(uint logLevel); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spinlock_lock(ref uint pSpinlock); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spinlock_lock_noyield(ref uint pSpinlock); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_spinlock_unlock(ref uint pSpinlock); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_mutex_init(ref IntPtr pMutex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_mutex_uninit(ref IntPtr pMutex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_mutex_lock(ref IntPtr pMutex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_mutex_unlock(ref IntPtr pMutex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_event_init(ref ma_event pEvent); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_event_uninit(ref ma_event pEvent); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_event_wait(ref ma_event pEvent); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_event_signal(ref ma_event pEvent); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_semaphore_init(int initialValue, ref ma_semaphore pSemaphore); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_semaphore_uninit(ref ma_semaphore pSemaphore); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_semaphore_wait(ref ma_semaphore pSemaphore); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_semaphore_release(ref ma_semaphore pSemaphore); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_fence
    {
        public ma_event e;
        public uint counter;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_fence_init(ref ma_fence pFence); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_fence_uninit(ref ma_fence pFence); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_fence_acquire(ref ma_fence pFence); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_fence_release(ref ma_fence pFence); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_fence_wait(ref ma_fence pFence); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_async_notification_callbacks
    {
        public IntPtr onSignal; // WARN_ANONYMOUS_FUNCTION_POINTER
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_async_notification_signal(IntPtr pNotification);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_async_notification_poll
    {
        public ma_async_notification_callbacks cb;
        public uint signalled;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_async_notification_poll_init(ref ma_async_notification_poll pNotificationPoll); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_async_notification_poll_is_signalled(ref ma_async_notification_poll pNotificationPoll); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_async_notification_event
    {
        public ma_async_notification_callbacks cb;
        public ma_event e;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_async_notification_event_init(ref ma_async_notification_event pNotificationEvent); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_async_notification_event_uninit(ref ma_async_notification_event pNotificationEvent); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_async_notification_event_wait(ref ma_async_notification_event pNotificationEvent); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_async_notification_event_signal(ref ma_async_notification_event pNotificationEvent); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_slot_allocator_config
    {
        public uint capacity;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_slot_allocator_config ma_slot_allocator_config_init(uint capacity);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_slot_allocator_group
    {
        public uint bitfield;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_slot_allocator
    {
        public ma_slot_allocator_group* pGroups;
        public uint* pSlots;
        public uint count;
        public uint capacity;
        public uint _ownsHeap;
        public IntPtr _pHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_slot_allocator_get_heap_size(ref ma_slot_allocator_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_slot_allocator_init_preallocated(ref ma_slot_allocator_config pConfig, IntPtr pHeap, ref ma_slot_allocator pAllocator); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_slot_allocator_init(ref ma_slot_allocator_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_slot_allocator pAllocator); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_slot_allocator_uninit(ref ma_slot_allocator pAllocator, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_slot_allocator_alloc(ref ma_slot_allocator pAllocator, ref ulong pSlot); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_slot_allocator_free(ref ma_slot_allocator pAllocator, ulong slot); // WARN_UNKNOWN_POINTER_PARAMETER

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_job_proc(ma_job* pJob);

    public enum ma_job_type
    {
        MA_JOB_TYPE_QUIT = 0,
        MA_JOB_TYPE_CUSTOM = 1,
        MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_BUFFER_NODE = 2,
        MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_BUFFER_NODE = 3,
        MA_JOB_TYPE_RESOURCE_MANAGER_PAGE_DATA_BUFFER_NODE = 4,
        MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_BUFFER = 5,
        MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_BUFFER = 6,
        MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_STREAM = 7,
        MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_STREAM = 8,
        MA_JOB_TYPE_RESOURCE_MANAGER_PAGE_DATA_STREAM = 9,
        MA_JOB_TYPE_RESOURCE_MANAGER_SEEK_DATA_STREAM = 10,
        MA_JOB_TYPE_DEVICE_AAUDIO_REROUTE = 11,
        MA_JOB_TYPE_COUNT = 12,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_job
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct toc
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct breakup
            {
                public ushort code;
                public ushort slot;
                public uint refcount;
            }


            [FieldOffset(0)]
            public ulong allocation;
        }


        public ulong next;
        public uint order;
        [StructLayout(LayoutKind.Explicit)]
        public struct data
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct custom
            {
                public IntPtr proc; // ma_job_proc
                public ulong data0;
                public ulong data1;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Explicit)]
            public struct resourceManager
            {
                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct loadDataBufferNode
                {
                    public IntPtr pResourceManager;
                    public IntPtr pDataBufferNode;
                    public byte* pFilePath;
                    public byte* pFilePathW;
                    public uint flags;
                    public IntPtr pInitNotification;
                    public IntPtr pDoneNotification;
                    public ma_fence* pInitFence;
                    public ma_fence* pDoneFence;
                }


                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct freeDataBufferNode
                {
                    public IntPtr pResourceManager;
                    public IntPtr pDataBufferNode;
                    public IntPtr pDoneNotification;
                    public ma_fence* pDoneFence;
                }


                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct pageDataBufferNode
                {
                    public IntPtr pResourceManager;
                    public IntPtr pDataBufferNode;
                    public IntPtr pDecoder;
                    public IntPtr pDoneNotification;
                    public ma_fence* pDoneFence;
                }


                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct loadDataBuffer
                {
                    public IntPtr pDataBuffer;
                    public IntPtr pInitNotification;
                    public IntPtr pDoneNotification;
                    public ma_fence* pInitFence;
                    public ma_fence* pDoneFence;
                    public ulong rangeBegInPCMFrames;
                    public ulong rangeEndInPCMFrames;
                    public ulong loopPointBegInPCMFrames;
                    public ulong loopPointEndInPCMFrames;
                    public uint isLooping;
                }


                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct freeDataBuffer
                {
                    public IntPtr pDataBuffer;
                    public IntPtr pDoneNotification;
                    public ma_fence* pDoneFence;
                }


                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct loadDataStream
                {
                    public IntPtr pDataStream;
                    public byte* pFilePath;
                    public byte* pFilePathW;
                    public ulong initialSeekPoint;
                    public IntPtr pInitNotification;
                    public ma_fence* pInitFence;
                }


                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct freeDataStream
                {
                    public IntPtr pDataStream;
                    public IntPtr pDoneNotification;
                    public ma_fence* pDoneFence;
                }


                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct pageDataStream
                {
                    public IntPtr pDataStream;
                    public uint pageIndex;
                }


                [FieldOffset(0)]
                [StructLayout(LayoutKind.Sequential)]
                public struct seekDataStream
                {
                    public IntPtr pDataStream;
                    public ulong frameIndex;
                }


            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Explicit)]
            public struct device
            {
                [FieldOffset(0)]
                [StructLayout(LayoutKind.Explicit)]
                public struct aaudio
                {
                    [FieldOffset(0)]
                    [StructLayout(LayoutKind.Sequential)]
                    public struct reroute
                    {
                        public IntPtr pDevice;
                        public uint deviceType;
                    }


                }


            }


        }


    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_job ma_job_init(ushort code);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_job_process(IntPtr pJob); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_job_queue_flags
    {
        MA_JOB_QUEUE_FLAG_NON_BLOCKING = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_job_queue_config
    {
        public uint flags;
        public uint capacity;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_job_queue_config ma_job_queue_config_init(uint flags, uint capacity);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_job_queue
    {
        public uint flags;
        public uint capacity;
        public ulong head;
        public ulong tail;
        public ma_semaphore sem;
        public ma_slot_allocator allocator;
        public ma_job* pJobs;
        public uint @lock;
        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_job_queue_get_heap_size(ref ma_job_queue_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_job_queue_init_preallocated(ref ma_job_queue_config pConfig, IntPtr pHeap, ref ma_job_queue pQueue); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_job_queue_init(ref ma_job_queue_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_job_queue pQueue); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_job_queue_uninit(ref ma_job_queue pQueue, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_job_queue_post(ref ma_job_queue pQueue, IntPtr pJob); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_job_queue_next(ref ma_job_queue pQueue, IntPtr pJob); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_device_state
    {
        ma_device_state_uninitialized = 0,
        ma_device_state_stopped = 1,
        ma_device_state_started = 2,
        ma_device_state_starting = 3,
        ma_device_state_stopping = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_atomic_device_state
    {
        public ma_device_state value;
    }

    public enum ma_backend
    {
        ma_backend_wasapi = 0,
        ma_backend_dsound = 1,
        ma_backend_winmm = 2,
        ma_backend_coreaudio = 3,
        ma_backend_sndio = 4,
        ma_backend_audio4 = 5,
        ma_backend_oss = 6,
        ma_backend_pulseaudio = 7,
        ma_backend_alsa = 8,
        ma_backend_jack = 9,
        ma_backend_aaudio = 10,
        ma_backend_opensl = 11,
        ma_backend_webaudio = 12,
        ma_backend_custom = 13,
        ma_backend_null = 14,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_device_job_thread_config
    {
        public uint noThread;
        public uint jobQueueCapacity;
        public uint jobQueueFlags;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_device_job_thread_config ma_device_job_thread_config_init();

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_device_job_thread
    {
        public IntPtr thread;
        public ma_job_queue jobQueue;
        public uint _hasThread;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_job_thread_init(ref ma_device_job_thread_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_device_job_thread pJobThread); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_device_job_thread_uninit(ref ma_device_job_thread pJobThread, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_job_thread_post(ref ma_device_job_thread pJobThread, IntPtr pJob); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_job_thread_next(ref ma_device_job_thread pJobThread, IntPtr pJob); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_device_notification_type
    {
        ma_device_notification_type_started = 0,
        ma_device_notification_type_stopped = 1,
        ma_device_notification_type_rerouted = 2,
        ma_device_notification_type_interruption_began = 3,
        ma_device_notification_type_interruption_ended = 4,
        ma_device_notification_type_unlocked = 5,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_device_notification
    {
        public ma_device* pDevice;
        public ma_device_notification_type type;
        [StructLayout(LayoutKind.Explicit)]
        public struct data
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct started
            {
                public int _unused;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct stopped
            {
                public int _unused;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct rerouted
            {
                public int _unused;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct interruption
            {
                public int _unused;
            }


        }


    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ma_device_notification_proc(ma_device_notification* pNotification);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ma_device_data_proc(ma_device* pDevice, void* pOutput, void* pInput, uint frameCount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ma_stop_proc(ma_device* pDevice);

    public enum ma_device_type
    {
        ma_device_type_playback = 1,
        ma_device_type_capture = 2,
        ma_device_type_duplex = 3,
        ma_device_type_loopback = 4,
    }

    public enum ma_share_mode
    {
        ma_share_mode_shared = 0,
        ma_share_mode_exclusive = 1,
    }

    public enum ma_ios_session_category
    {
        ma_ios_session_category_default = 0,
        ma_ios_session_category_none = 1,
        ma_ios_session_category_ambient = 2,
        ma_ios_session_category_solo_ambient = 3,
        ma_ios_session_category_playback = 4,
        ma_ios_session_category_record = 5,
        ma_ios_session_category_play_and_record = 6,
        ma_ios_session_category_multi_route = 7,
    }

    public enum ma_ios_session_category_option
    {
        ma_ios_session_category_option_mix_with_others = 1,
        ma_ios_session_category_option_duck_others = 2,
        ma_ios_session_category_option_allow_bluetooth = 4,
        ma_ios_session_category_option_default_to_speaker = 8,
        ma_ios_session_category_option_interrupt_spoken_audio_and_mix_with_others = 17,
        ma_ios_session_category_option_allow_bluetooth_a2dp = 32,
        ma_ios_session_category_option_allow_air_play = 64,
    }

    public enum ma_opensl_stream_type
    {
        ma_opensl_stream_type_default = 0,
        ma_opensl_stream_type_voice = 1,
        ma_opensl_stream_type_system = 2,
        ma_opensl_stream_type_ring = 3,
        ma_opensl_stream_type_media = 4,
        ma_opensl_stream_type_alarm = 5,
        ma_opensl_stream_type_notification = 6,
    }

    public enum ma_opensl_recording_preset
    {
        ma_opensl_recording_preset_default = 0,
        ma_opensl_recording_preset_generic = 1,
        ma_opensl_recording_preset_camcorder = 2,
        ma_opensl_recording_preset_voice_recognition = 3,
        ma_opensl_recording_preset_voice_communication = 4,
        ma_opensl_recording_preset_voice_unprocessed = 5,
    }

    public enum ma_wasapi_usage
    {
        ma_wasapi_usage_default = 0,
        ma_wasapi_usage_games = 1,
        ma_wasapi_usage_pro_audio = 2,
    }

    public enum ma_aaudio_usage
    {
        ma_aaudio_usage_default = 0,
        ma_aaudio_usage_media = 1,
        ma_aaudio_usage_voice_communication = 2,
        ma_aaudio_usage_voice_communication_signalling = 3,
        ma_aaudio_usage_alarm = 4,
        ma_aaudio_usage_notification = 5,
        ma_aaudio_usage_notification_ringtone = 6,
        ma_aaudio_usage_notification_event = 7,
        ma_aaudio_usage_assistance_accessibility = 8,
        ma_aaudio_usage_assistance_navigation_guidance = 9,
        ma_aaudio_usage_assistance_sonification = 10,
        ma_aaudio_usage_game = 11,
        ma_aaudio_usage_assitant = 12,
        ma_aaudio_usage_emergency = 13,
        ma_aaudio_usage_safety = 14,
        ma_aaudio_usage_vehicle_status = 15,
        ma_aaudio_usage_announcement = 16,
    }

    public enum ma_aaudio_content_type
    {
        ma_aaudio_content_type_default = 0,
        ma_aaudio_content_type_speech = 1,
        ma_aaudio_content_type_music = 2,
        ma_aaudio_content_type_movie = 3,
        ma_aaudio_content_type_sonification = 4,
    }

    public enum ma_aaudio_input_preset
    {
        ma_aaudio_input_preset_default = 0,
        ma_aaudio_input_preset_generic = 1,
        ma_aaudio_input_preset_camcorder = 2,
        ma_aaudio_input_preset_voice_recognition = 3,
        ma_aaudio_input_preset_voice_communication = 4,
        ma_aaudio_input_preset_unprocessed = 5,
        ma_aaudio_input_preset_voice_performance = 6,
    }

    public enum ma_aaudio_allowed_capture_policy
    {
        ma_aaudio_allow_capture_default = 0,
        ma_aaudio_allow_capture_by_all = 1,
        ma_aaudio_allow_capture_by_system = 2,
        ma_aaudio_allow_capture_by_none = 3,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ma_timer
    {
        [FieldOffset(0)]
        public long counter;
        [FieldOffset(0)]
        public double counterD;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ma_device_id
    {
        [FieldOffset(0)]
        public fixed ushort wasapi[64];
        [FieldOffset(0)]
        public fixed byte dsound[16];
        [FieldOffset(0)]
        public uint winmm;
        [FieldOffset(0)]
        public fixed byte alsa[256];
        [FieldOffset(0)]
        public fixed byte pulse[256];
        [FieldOffset(0)]
        public int jack;
        [FieldOffset(0)]
        public fixed byte coreaudio[256];
        [FieldOffset(0)]
        public fixed byte sndio[256];
        [FieldOffset(0)]
        public fixed byte audio4[256];
        [FieldOffset(0)]
        public fixed byte oss[64];
        [FieldOffset(0)]
        public int aaudio;
        [FieldOffset(0)]
        public uint opensl;
        [FieldOffset(0)]
        public fixed byte webaudio[32];
        [FieldOffset(0)]
        [StructLayout(LayoutKind.Explicit)]
        public struct custom
        {
            [FieldOffset(0)]
            public int i;
            [FieldOffset(0)]
            public fixed byte s[256];
            [FieldOffset(0)]
            public IntPtr p;
        }


        [FieldOffset(0)]
        public int nullbackend;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_device_id_equal(ref pA, ref pB); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_device_info
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct id
        {
            [FieldOffset(0)]
            public fixed ushort wasapi[64];
            [FieldOffset(0)]
            public fixed byte dsound[16];
            [FieldOffset(0)]
            public uint winmm;
            [FieldOffset(0)]
            public fixed byte alsa[256];
            [FieldOffset(0)]
            public fixed byte pulse[256];
            [FieldOffset(0)]
            public int jack;
            [FieldOffset(0)]
            public fixed byte coreaudio[256];
            [FieldOffset(0)]
            public fixed byte sndio[256];
            [FieldOffset(0)]
            public fixed byte audio4[256];
            [FieldOffset(0)]
            public fixed byte oss[64];
            [FieldOffset(0)]
            public int aaudio;
            [FieldOffset(0)]
            public uint opensl;
            [FieldOffset(0)]
            public fixed byte webaudio[32];
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Explicit)]
            public struct custom
            {
                [FieldOffset(0)]
                public int i;
                [FieldOffset(0)]
                public fixed byte s[256];
                [FieldOffset(0)]
                public IntPtr p;
            }


            [FieldOffset(0)]
            public int nullbackend;
        }


        public fixed byte name[256];
        public uint isDefault;
        public uint nativeDataFormatCount;
        [StructLayout(LayoutKind.Sequential)]
        public struct ma_nativeDataFormat
        {
            public ma_format format;
            public uint channels;
            public uint sampleRate;
            public uint flags;
        }


        public ma_nativeDataFormat__InlineArray nativeDataFormats;
        [InlineArray(64)]
        public partial struct ma_nativeDataFormat__InlineArray
        {
            public ma_nativeDataFormat _value;
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_device_config
    {
        public ma_device_type deviceType;
        public uint sampleRate;
        public uint periodSizeInFrames;
        public uint periodSizeInMilliseconds;
        public uint periods;
        public ma_performance_profile performanceProfile;
        public byte noPreSilencedOutputBuffer;
        public byte noClip;
        public byte noDisableDenormals;
        public byte noFixedSizedCallback;
        public IntPtr dataCallback; // ma_device_data_proc
        public IntPtr notificationCallback; // ma_device_notification_proc
        public IntPtr stopCallback; // ma_stop_proc
        public IntPtr pUserData;
        public ma_resampler_config resampling;
        [StructLayout(LayoutKind.Sequential)]
        public struct playback
        {
            public * pDeviceID;
            public ma_format format;
            public uint channels;
            public byte* pChannelMap;
            public ma_channel_mix_mode channelMixMode;
            public uint calculateLFEFromSpatialChannels;
            public ma_share_mode shareMode;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct capture
        {
            public * pDeviceID;
            public ma_format format;
            public uint channels;
            public byte* pChannelMap;
            public ma_channel_mix_mode channelMixMode;
            public uint calculateLFEFromSpatialChannels;
            public ma_share_mode shareMode;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct wasapi
        {
            public ma_wasapi_usage usage;
            public byte noAutoConvertSRC;
            public byte noDefaultQualitySRC;
            public byte noAutoStreamRouting;
            public byte noHardwareOffloading;
            public uint loopbackProcessID;
            public byte loopbackProcessExclude;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct alsa
        {
            public uint noMMap;
            public uint noAutoFormat;
            public uint noAutoChannels;
            public uint noAutoResample;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct pulse
        {
            public byte* pStreamNamePlayback;
            public byte* pStreamNameCapture;
            public int channelMap;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct coreaudio
        {
            public uint allowNominalSampleRateChange;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct opensl
        {
            public ma_opensl_stream_type streamType;
            public ma_opensl_recording_preset recordingPreset;
            public uint enableCompatibilityWorkarounds;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct aaudio
        {
            public ma_aaudio_usage usage;
            public ma_aaudio_content_type contentType;
            public ma_aaudio_input_preset inputPreset;
            public ma_aaudio_allowed_capture_policy allowedCapturePolicy;
            public uint noAutoStartAfterReroute;
            public uint enableCompatibilityWorkarounds;
            public uint allowSetBufferCapacity;
        }


    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint ma_enum_devices_callback_proc(ma_context* pContext, ma_device_type deviceType, ma_device_info* pInfo, void* pUserData);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_device_descriptor
    {
        public * pDeviceID;
        public ma_share_mode shareMode;
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public fixed byte channelMap[254];
        public uint periodSizeInFrames;
        public uint periodSizeInMilliseconds;
        public uint periodCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_backend_callbacks
    {
        public IntPtr onContextInit; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onContextUninit; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onContextEnumerateDevices; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onContextGetDeviceInfo; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceInit; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceUninit; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceStart; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceStop; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceRead; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceWrite; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceDataLoop; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceDataLoopWakeup; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onDeviceGetInfo; // WARN_ANONYMOUS_FUNCTION_POINTER
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_context_config
    {
        public ma_log* pLog;
        public ma_thread_priority threadPriority;
        public UIntPtr threadStackSize;
        public IntPtr pUserData;
        public ma_allocation_callbacks allocationCallbacks;
        [StructLayout(LayoutKind.Sequential)]
        public struct dsound
        {
            public IntPtr hWnd;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct alsa
        {
            public uint useVerboseDeviceEnumeration;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct pulse
        {
            public byte* pApplicationName;
            public byte* pServerName;
            public uint tryAutoSpawn;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct coreaudio
        {
            public ma_ios_session_category sessionCategory;
            public uint sessionCategoryOptions;
            public uint noAudioSessionActivate;
            public uint noAudioSessionDeactivate;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct jack
        {
            public byte* pClientName;
            public uint tryStartServer;
        }


        public ma_backend_callbacks custom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_context_command__wasapi
    {
        public int code;
        public ma_event* pEvent;
        [StructLayout(LayoutKind.Explicit)]
        public struct data
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct quit
            {
                public int _unused;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct createAudioClient
            {
                public ma_device_type deviceType;
                public IntPtr pAudioClient;
                public IntPtr* ppAudioClientService;
                public ma_result* pResult;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct releaseAudioClient
            {
                public ma_device* pDevice;
                public ma_device_type deviceType;
            }


        }


    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_context
    {
        public ma_backend_callbacks callbacks;
        public ma_backend backend;
        public ma_log* pLog;
        public ma_log log;
        public ma_thread_priority threadPriority;
        public UIntPtr threadStackSize;
        public IntPtr pUserData;
        public ma_allocation_callbacks allocationCallbacks;
        public IntPtr deviceEnumLock;
        public IntPtr deviceInfoLock;
        public uint deviceInfoCapacity;
        public uint playbackDeviceInfoCount;
        public uint captureDeviceInfoCount;
        public ma_device_info* pDeviceInfos;
        [StructLayout(LayoutKind.Explicit)]
        public struct Anonymous0
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct alsa
            {
                public IntPtr asoundSO;
                public IntPtr snd_pcm_open;
                public IntPtr snd_pcm_close;
                public IntPtr snd_pcm_hw_params_sizeof;
                public IntPtr snd_pcm_hw_params_any;
                public IntPtr snd_pcm_hw_params_set_format;
                public IntPtr snd_pcm_hw_params_set_format_first;
                public IntPtr snd_pcm_hw_params_get_format_mask;
                public IntPtr snd_pcm_hw_params_set_channels;
                public IntPtr snd_pcm_hw_params_set_channels_near;
                public IntPtr snd_pcm_hw_params_set_channels_minmax;
                public IntPtr snd_pcm_hw_params_set_rate_resample;
                public IntPtr snd_pcm_hw_params_set_rate;
                public IntPtr snd_pcm_hw_params_set_rate_near;
                public IntPtr snd_pcm_hw_params_set_rate_minmax;
                public IntPtr snd_pcm_hw_params_set_buffer_size_near;
                public IntPtr snd_pcm_hw_params_set_periods_near;
                public IntPtr snd_pcm_hw_params_set_access;
                public IntPtr snd_pcm_hw_params_get_format;
                public IntPtr snd_pcm_hw_params_get_channels;
                public IntPtr snd_pcm_hw_params_get_channels_min;
                public IntPtr snd_pcm_hw_params_get_channels_max;
                public IntPtr snd_pcm_hw_params_get_rate;
                public IntPtr snd_pcm_hw_params_get_rate_min;
                public IntPtr snd_pcm_hw_params_get_rate_max;
                public IntPtr snd_pcm_hw_params_get_buffer_size;
                public IntPtr snd_pcm_hw_params_get_periods;
                public IntPtr snd_pcm_hw_params_get_access;
                public IntPtr snd_pcm_hw_params_test_format;
                public IntPtr snd_pcm_hw_params_test_channels;
                public IntPtr snd_pcm_hw_params_test_rate;
                public IntPtr snd_pcm_hw_params;
                public IntPtr snd_pcm_sw_params_sizeof;
                public IntPtr snd_pcm_sw_params_current;
                public IntPtr snd_pcm_sw_params_get_boundary;
                public IntPtr snd_pcm_sw_params_set_avail_min;
                public IntPtr snd_pcm_sw_params_set_start_threshold;
                public IntPtr snd_pcm_sw_params_set_stop_threshold;
                public IntPtr snd_pcm_sw_params;
                public IntPtr snd_pcm_format_mask_sizeof;
                public IntPtr snd_pcm_format_mask_test;
                public IntPtr snd_pcm_get_chmap;
                public IntPtr snd_pcm_state;
                public IntPtr snd_pcm_prepare;
                public IntPtr snd_pcm_start;
                public IntPtr snd_pcm_drop;
                public IntPtr snd_pcm_drain;
                public IntPtr snd_pcm_reset;
                public IntPtr snd_device_name_hint;
                public IntPtr snd_device_name_get_hint;
                public IntPtr snd_card_get_index;
                public IntPtr snd_device_name_free_hint;
                public IntPtr snd_pcm_mmap_begin;
                public IntPtr snd_pcm_mmap_commit;
                public IntPtr snd_pcm_recover;
                public IntPtr snd_pcm_readi;
                public IntPtr snd_pcm_writei;
                public IntPtr snd_pcm_avail;
                public IntPtr snd_pcm_avail_update;
                public IntPtr snd_pcm_wait;
                public IntPtr snd_pcm_nonblock;
                public IntPtr snd_pcm_info;
                public IntPtr snd_pcm_info_sizeof;
                public IntPtr snd_pcm_info_get_name;
                public IntPtr snd_pcm_poll_descriptors;
                public IntPtr snd_pcm_poll_descriptors_count;
                public IntPtr snd_pcm_poll_descriptors_revents;
                public IntPtr snd_config_update_free_global;
                public IntPtr internalDeviceEnumLock;
                public uint useVerboseDeviceEnumeration;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct pulse
            {
                public IntPtr pulseSO;
                public IntPtr pa_mainloop_new;
                public IntPtr pa_mainloop_free;
                public IntPtr pa_mainloop_quit;
                public IntPtr pa_mainloop_get_api;
                public IntPtr pa_mainloop_iterate;
                public IntPtr pa_mainloop_wakeup;
                public IntPtr pa_threaded_mainloop_new;
                public IntPtr pa_threaded_mainloop_free;
                public IntPtr pa_threaded_mainloop_start;
                public IntPtr pa_threaded_mainloop_stop;
                public IntPtr pa_threaded_mainloop_lock;
                public IntPtr pa_threaded_mainloop_unlock;
                public IntPtr pa_threaded_mainloop_wait;
                public IntPtr pa_threaded_mainloop_signal;
                public IntPtr pa_threaded_mainloop_accept;
                public IntPtr pa_threaded_mainloop_get_retval;
                public IntPtr pa_threaded_mainloop_get_api;
                public IntPtr pa_threaded_mainloop_in_thread;
                public IntPtr pa_threaded_mainloop_set_name;
                public IntPtr pa_context_new;
                public IntPtr pa_context_unref;
                public IntPtr pa_context_connect;
                public IntPtr pa_context_disconnect;
                public IntPtr pa_context_set_state_callback;
                public IntPtr pa_context_get_state;
                public IntPtr pa_context_get_sink_info_list;
                public IntPtr pa_context_get_source_info_list;
                public IntPtr pa_context_get_sink_info_by_name;
                public IntPtr pa_context_get_source_info_by_name;
                public IntPtr pa_operation_unref;
                public IntPtr pa_operation_get_state;
                public IntPtr pa_channel_map_init_extend;
                public IntPtr pa_channel_map_valid;
                public IntPtr pa_channel_map_compatible;
                public IntPtr pa_stream_new;
                public IntPtr pa_stream_unref;
                public IntPtr pa_stream_connect_playback;
                public IntPtr pa_stream_connect_record;
                public IntPtr pa_stream_disconnect;
                public IntPtr pa_stream_get_state;
                public IntPtr pa_stream_get_sample_spec;
                public IntPtr pa_stream_get_channel_map;
                public IntPtr pa_stream_get_buffer_attr;
                public IntPtr pa_stream_set_buffer_attr;
                public IntPtr pa_stream_get_device_name;
                public IntPtr pa_stream_set_write_callback;
                public IntPtr pa_stream_set_read_callback;
                public IntPtr pa_stream_set_suspended_callback;
                public IntPtr pa_stream_set_moved_callback;
                public IntPtr pa_stream_is_suspended;
                public IntPtr pa_stream_flush;
                public IntPtr pa_stream_drain;
                public IntPtr pa_stream_is_corked;
                public IntPtr pa_stream_cork;
                public IntPtr pa_stream_trigger;
                public IntPtr pa_stream_begin_write;
                public IntPtr pa_stream_write;
                public IntPtr pa_stream_peek;
                public IntPtr pa_stream_drop;
                public IntPtr pa_stream_writable_size;
                public IntPtr pa_stream_readable_size;
                public IntPtr pMainLoop;
                public IntPtr pPulseContext;
                public byte* pApplicationName;
                public byte* pServerName;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct jack
            {
                public IntPtr jackSO;
                public IntPtr jack_client_open;
                public IntPtr jack_client_close;
                public IntPtr jack_client_name_size;
                public IntPtr jack_set_process_callback;
                public IntPtr jack_set_buffer_size_callback;
                public IntPtr jack_on_shutdown;
                public IntPtr jack_get_sample_rate;
                public IntPtr jack_get_buffer_size;
                public IntPtr jack_get_ports;
                public IntPtr jack_activate;
                public IntPtr jack_deactivate;
                public IntPtr jack_connect;
                public IntPtr jack_port_register;
                public IntPtr jack_port_name;
                public IntPtr jack_port_get_buffer;
                public IntPtr jack_free;
                public byte* pClientName;
                public uint tryStartServer;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct null_backend
            {
                public int _unused;
            }


        }


        [StructLayout(LayoutKind.Explicit)]
        public struct Anonymous1
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct posix
            {
                public int _unused;
            }


            [FieldOffset(0)]
            public int _unused;
        }


    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_device
    {
        public ma_context* pContext;
        public ma_device_type type;
        public uint sampleRate;
        public ma_atomic_device_state state;
        public IntPtr onData; // ma_device_data_proc
        public IntPtr onNotification; // ma_device_notification_proc
        public IntPtr onStop; // ma_stop_proc
        public IntPtr pUserData;
        public IntPtr startStopLock;
        public ma_event wakeupEvent;
        public ma_event startEvent;
        public ma_event stopEvent;
        public IntPtr thread;
        public ma_result workResult;
        public byte isOwnerOfContext;
        public byte noPreSilencedOutputBuffer;
        public byte noClip;
        public byte noDisableDenormals;
        public byte noFixedSizedCallback;
        public ma_atomic_float masterVolumeFactor;
        public ma_duplex_rb duplexRB;
        [StructLayout(LayoutKind.Sequential)]
        public struct resampling
        {
            public ma_resample_algorithm algorithm;
            public ma_resampling_backend_vtable* pBackendVTable;
            public IntPtr pBackendUserData;
            [StructLayout(LayoutKind.Sequential)]
            public struct linear
            {
                public uint lpfOrder;
            }


        }


        [StructLayout(LayoutKind.Sequential)]
        public struct playback
        {
            public * pID;
            [StructLayout(LayoutKind.Explicit)]
            public struct id
            {
                [FieldOffset(0)]
                public fixed ushort wasapi[64];
                [FieldOffset(0)]
                public fixed byte dsound[16];
                [FieldOffset(0)]
                public uint winmm;
                [FieldOffset(0)]
                public fixed byte alsa[256];
                [FieldOffset(0)]
                public fixed byte pulse[256];
                [FieldOffset(0)]
                public int jack;
                [FieldOffset(0)]
                public fixed byte coreaudio[256];
                [FieldOffset(0)]
                public fixed byte sndio[256];
                [FieldOffset(0)]
                public fixed byte audio4[256];
                [FieldOffset(0)]
                public fixed byte oss[64];
                [FieldOffset(0)]
                public int aaudio;
                [FieldOffset(0)]
                public uint opensl;
                [FieldOffset(0)]
                public fixed byte webaudio[32];
                [FieldOffset(0)]
                [StructLayout(LayoutKind.Explicit)]
                public struct custom
                {
                    [FieldOffset(0)]
                    public int i;
                    [FieldOffset(0)]
                    public fixed byte s[256];
                    [FieldOffset(0)]
                    public IntPtr p;
                }


                [FieldOffset(0)]
                public int nullbackend;
            }


            public fixed byte name[256];
            public ma_share_mode shareMode;
            public ma_format format;
            public uint channels;
            public fixed byte channelMap[254];
            public ma_format internalFormat;
            public uint internalChannels;
            public uint internalSampleRate;
            public fixed byte internalChannelMap[254];
            public uint internalPeriodSizeInFrames;
            public uint internalPeriods;
            public ma_channel_mix_mode channelMixMode;
            public uint calculateLFEFromSpatialChannels;
            public ma_data_converter converter;
            public IntPtr pIntermediaryBuffer;
            public uint intermediaryBufferCap;
            public uint intermediaryBufferLen;
            public IntPtr pInputCache;
            public ulong inputCacheCap;
            public ulong inputCacheConsumed;
            public ulong inputCacheRemaining;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct capture
        {
            public * pID;
            [StructLayout(LayoutKind.Explicit)]
            public struct id
            {
                [FieldOffset(0)]
                public fixed ushort wasapi[64];
                [FieldOffset(0)]
                public fixed byte dsound[16];
                [FieldOffset(0)]
                public uint winmm;
                [FieldOffset(0)]
                public fixed byte alsa[256];
                [FieldOffset(0)]
                public fixed byte pulse[256];
                [FieldOffset(0)]
                public int jack;
                [FieldOffset(0)]
                public fixed byte coreaudio[256];
                [FieldOffset(0)]
                public fixed byte sndio[256];
                [FieldOffset(0)]
                public fixed byte audio4[256];
                [FieldOffset(0)]
                public fixed byte oss[64];
                [FieldOffset(0)]
                public int aaudio;
                [FieldOffset(0)]
                public uint opensl;
                [FieldOffset(0)]
                public fixed byte webaudio[32];
                [FieldOffset(0)]
                [StructLayout(LayoutKind.Explicit)]
                public struct custom
                {
                    [FieldOffset(0)]
                    public int i;
                    [FieldOffset(0)]
                    public fixed byte s[256];
                    [FieldOffset(0)]
                    public IntPtr p;
                }


                [FieldOffset(0)]
                public int nullbackend;
            }


            public fixed byte name[256];
            public ma_share_mode shareMode;
            public ma_format format;
            public uint channels;
            public fixed byte channelMap[254];
            public ma_format internalFormat;
            public uint internalChannels;
            public uint internalSampleRate;
            public fixed byte internalChannelMap[254];
            public uint internalPeriodSizeInFrames;
            public uint internalPeriods;
            public ma_channel_mix_mode channelMixMode;
            public uint calculateLFEFromSpatialChannels;
            public ma_data_converter converter;
            public IntPtr pIntermediaryBuffer;
            public uint intermediaryBufferCap;
            public uint intermediaryBufferLen;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct Anonymous0
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct alsa
            {
                public IntPtr pPCMPlayback;
                public IntPtr pPCMCapture;
                public IntPtr pPollDescriptorsPlayback;
                public IntPtr pPollDescriptorsCapture;
                public int pollDescriptorCountPlayback;
                public int pollDescriptorCountCapture;
                public int wakeupfdPlayback;
                public int wakeupfdCapture;
                public byte isUsingMMapPlayback;
                public byte isUsingMMapCapture;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct pulse
            {
                public IntPtr pMainLoop;
                public IntPtr pPulseContext;
                public IntPtr pStreamPlayback;
                public IntPtr pStreamCapture;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct jack
            {
                public IntPtr pClient;
                public IntPtr* ppPortsPlayback;
                public IntPtr* ppPortsCapture;
                public float* pIntermediaryBufferPlayback;
                public float* pIntermediaryBufferCapture;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct null_device
            {
                public IntPtr deviceThread;
                public ma_event operationEvent;
                public ma_event operationCompletionEvent;
                public ma_semaphore operationSemaphore;
                public uint operation;
                public ma_result operationResult;
                [StructLayout(LayoutKind.Explicit)]
                public struct timer
                {
                    [FieldOffset(0)]
                    public long counter;
                    [FieldOffset(0)]
                    public double counterD;
                }


                public double priorRunTime;
                public uint currentPeriodFramesRemainingPlayback;
                public uint currentPeriodFramesRemainingCapture;
                public ulong lastProcessedFramePlayback;
                public ulong lastProcessedFrameCapture;
                public ma_atomic_bool32 isStarted;
            }


        }


    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_context_config ma_context_config_init();

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_context_init(IntPtr backends, uint backendCount, IntPtr pConfig, IntPtr pContext); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_context_uninit(IntPtr pContext); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial UIntPtr ma_context_sizeof();

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_log* ma_context_get_log(IntPtr pContext); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_context_enumerate_devices(IntPtr pContext, ma_enum_devices_callback_proc callback, IntPtr pUserData); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_context_get_devices(IntPtr pContext, IntPtr ppPlaybackDeviceInfos, ref uint pPlaybackDeviceCount, IntPtr ppCaptureDeviceInfos, ref uint pCaptureDeviceCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_context_get_device_info(IntPtr pContext, ma_device_type deviceType, ref pDeviceID, ref ma_device_info pDeviceInfo); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_context_is_loopback_supported(IntPtr pContext); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_device_config ma_device_config_init(ma_device_type deviceType);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_init(IntPtr pContext, IntPtr pConfig, IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_init_ex(IntPtr backends, uint backendCount, IntPtr pContextConfig, IntPtr pConfig, IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_device_uninit(IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_device_get_context(IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_log* ma_device_get_log(IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_get_info(IntPtr pDevice, ma_device_type type, ref ma_device_info pDeviceInfo); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_get_name(IntPtr pDevice, ma_device_type type, IntPtr pName, UIntPtr nameCap, IntPtr pLengthNotIncludingNullTerminator); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_start(IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_stop(IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_device_is_started(IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_device_state ma_device_get_state(IntPtr pDevice); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_post_init(IntPtr pDevice, ma_device_type deviceType, ref ma_device_descriptor pPlaybackDescriptor, ref ma_device_descriptor pCaptureDescriptor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_set_master_volume(IntPtr pDevice, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_get_master_volume(IntPtr pDevice, IntPtr pVolume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_set_master_volume_db(IntPtr pDevice, float gainDB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_get_master_volume_db(IntPtr pDevice, IntPtr pGainDB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_device_handle_backend_data_callback(IntPtr pDevice, IntPtr pOutput, IntPtr pInput, uint frameCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_calculate_buffer_size_in_frames_from_descriptor(ref ma_device_descriptor pDescriptor, uint nativeSampleRate, ma_performance_profile performanceProfile); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_get_backend_name(ma_backend backend); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_get_backend_from_name(IntPtr pBackendName, IntPtr pBackend); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_is_backend_enabled(ma_backend backend);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_get_enabled_backends(IntPtr pBackends, UIntPtr backendCap, IntPtr pBackendCount); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_is_loopback_supported(ma_backend backend);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_calculate_buffer_size_in_milliseconds_from_frames(uint bufferSizeInFrames, uint sampleRate);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_calculate_buffer_size_in_frames_from_milliseconds(uint bufferSizeInMilliseconds, uint sampleRate);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_pcm_frames(IntPtr dst, IntPtr src, ulong frameCount, ma_format format, uint channels);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_silence_pcm_frames(IntPtr p, ulong frameCount, ma_format format, uint channels);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_offset_pcm_frames_ptr(IntPtr p, ulong offsetInFrames, ma_format format, uint channels);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_offset_pcm_frames_const_ptr(IntPtr p, ulong offsetInFrames, ma_format format, uint channels);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_offset_pcm_frames_ptr_f32(IntPtr p, ulong offsetInFrames, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_offset_pcm_frames_const_ptr_f32(IntPtr p, ulong offsetInFrames, uint channels); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_clip_samples_u8(ref byte pDst, ref short pSrc, ulong count); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_clip_samples_s16(ref short pDst, ref int pSrc, ulong count); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_clip_samples_s24(ref byte pDst, ref long pSrc, ulong count); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_clip_samples_s32(ref int pDst, ref long pSrc, ulong count); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_clip_samples_f32(IntPtr pDst, IntPtr pSrc, ulong count); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_clip_pcm_frames(IntPtr pDst, IntPtr pSrc, ulong frameCount, ma_format format, uint channels);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_u8(ref byte pSamplesOut, ref byte pSamplesIn, ulong sampleCount, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_s16(ref short pSamplesOut, ref short pSamplesIn, ulong sampleCount, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_s24(IntPtr pSamplesOut, IntPtr pSamplesIn, ulong sampleCount, float factor);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_s32(ref int pSamplesOut, ref int pSamplesIn, ulong sampleCount, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_f32(IntPtr pSamplesOut, IntPtr pSamplesIn, ulong sampleCount, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_u8(ref byte pSamples, ulong sampleCount, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_s16(ref short pSamples, ulong sampleCount, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_s24(IntPtr pSamples, ulong sampleCount, float factor);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_s32(ref int pSamples, ulong sampleCount, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_f32(IntPtr pSamples, ulong sampleCount, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_pcm_frames_u8(ref byte pFramesOut, ref byte pFramesIn, ulong frameCount, uint channels, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_pcm_frames_s16(ref short pFramesOut, ref short pFramesIn, ulong frameCount, uint channels, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_pcm_frames_s24(IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount, uint channels, float factor);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_pcm_frames_s32(ref int pFramesOut, ref int pFramesIn, ulong frameCount, uint channels, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_pcm_frames_f32(IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount, uint channels, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_pcm_frames(IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount, ma_format format, uint channels, float factor);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_pcm_frames_u8(ref byte pFrames, ulong frameCount, uint channels, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_pcm_frames_s16(ref short pFrames, ulong frameCount, uint channels, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_pcm_frames_s24(IntPtr pFrames, ulong frameCount, uint channels, float factor);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_pcm_frames_s32(ref int pFrames, ulong frameCount, uint channels, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_pcm_frames_f32(IntPtr pFrames, ulong frameCount, uint channels, float factor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_apply_volume_factor_pcm_frames(IntPtr pFrames, ulong frameCount, ma_format format, uint channels, float factor);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_factor_per_channel_f32(IntPtr pFramesOut, IntPtr pFramesIn, ulong frameCount, uint channels, IntPtr pChannelGains); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_and_clip_samples_u8(ref byte pDst, ref short pSrc, ulong count, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_and_clip_samples_s16(ref short pDst, ref int pSrc, ulong count, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_and_clip_samples_s24(ref byte pDst, ref long pSrc, ulong count, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_and_clip_samples_s32(ref int pDst, ref long pSrc, ulong count, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_and_clip_samples_f32(IntPtr pDst, IntPtr pSrc, ulong count, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_copy_and_apply_volume_and_clip_pcm_frames(IntPtr pDst, IntPtr pSrc, ulong frameCount, ma_format format, uint channels, float volume);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_volume_linear_to_db(float factor);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_volume_db_to_linear(float gain);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_mix_pcm_frames_f32(IntPtr pDst, IntPtr pSrc, ulong frameCount, uint channels, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_open_mode_flags
    {
        MA_OPEN_MODE_READ = 1,
        MA_OPEN_MODE_WRITE = 2,
    }

    public enum ma_seek_origin
    {
        ma_seek_origin_start = 0,
        ma_seek_origin_current = 1,
        ma_seek_origin_end = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_file_info
    {
        public ulong sizeInBytes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_vfs_callbacks
    {
        public IntPtr onOpen; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onOpenW; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onClose; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onRead; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onWrite; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onSeek; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onTell; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onInfo; // WARN_ANONYMOUS_FUNCTION_POINTER
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_open(IntPtr pVFS, IntPtr pFilePath, uint openMode, ref IntPtr pFile); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_open_w(IntPtr pVFS, string pFilePath, uint openMode, ref IntPtr pFile); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_close(IntPtr pVFS, IntPtr file);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_read(IntPtr pVFS, IntPtr file, IntPtr pDst, UIntPtr sizeInBytes, IntPtr pBytesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_write(IntPtr pVFS, IntPtr file, IntPtr pSrc, UIntPtr sizeInBytes, IntPtr pBytesWritten); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_seek(IntPtr pVFS, IntPtr file, long offset, ma_seek_origin origin);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_tell(IntPtr pVFS, IntPtr file, ref long pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_info(IntPtr pVFS, IntPtr file, ref ma_file_info pInfo); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_vfs_open_and_read_file(IntPtr pVFS, IntPtr pFilePath, IntPtr ppData, IntPtr pSize, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_default_vfs
    {
        public ma_vfs_callbacks cb;
        public ma_allocation_callbacks allocationCallbacks;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_default_vfs_init(ref ma_default_vfs pVFS, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_read_proc(void* pUserData, void* pBufferOut, nuint bytesToRead, nuint* pBytesRead);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_seek_proc(void* pUserData, long offset, ma_seek_origin origin);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_tell_proc(void* pUserData, long* pCursor);

    public enum ma_encoding_format
    {
        ma_encoding_format_unknown = 0,
        ma_encoding_format_wav = 1,
        ma_encoding_format_flac = 2,
        ma_encoding_format_mp3 = 3,
        ma_encoding_format_vorbis = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_decoding_backend_config
    {
        public ma_format preferredFormat;
        public uint seekPointCount;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_decoding_backend_config ma_decoding_backend_config_init(ma_format preferredFormat, uint seekPointCount);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_decoding_backend_vtable
    {
        public IntPtr onInit; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onInitFile; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onInitFileW; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onInitMemory; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onUninit; // WARN_ANONYMOUS_FUNCTION_POINTER
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_decoder_read_proc(ma_decoder* pDecoder, void* pBufferOut, nuint bytesToRead, nuint* pBytesRead);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_decoder_seek_proc(ma_decoder* pDecoder, long byteOffset, ma_seek_origin origin);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_decoder_tell_proc(ma_decoder* pDecoder, long* pCursor);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_decoder_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public byte* pChannelMap;
        public ma_channel_mix_mode channelMixMode;
        public ma_dither_mode ditherMode;
        public ma_resampler_config resampling;
        public ma_allocation_callbacks allocationCallbacks;
        public ma_encoding_format encodingFormat;
        public uint seekPointCount;
        public ma_decoding_backend_vtable** ppCustomBackendVTables;
        public uint customBackendCount;
        public IntPtr pCustomBackendUserData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_decoder
    {
        public ma_data_source_base ds;
        public IntPtr pBackend;
        public ma_decoding_backend_vtable* pBackendVTable;
        public IntPtr pBackendUserData;
        public IntPtr onRead; // ma_decoder_read_proc
        public IntPtr onSeek; // ma_decoder_seek_proc
        public IntPtr onTell; // ma_decoder_tell_proc
        public IntPtr pUserData;
        public ulong readPointerInPCMFrames;
        public ma_format outputFormat;
        public uint outputChannels;
        public uint outputSampleRate;
        public ma_data_converter converter;
        public IntPtr pInputCache;
        public ulong inputCacheCap;
        public ulong inputCacheConsumed;
        public ulong inputCacheRemaining;
        public ma_allocation_callbacks allocationCallbacks;
        [StructLayout(LayoutKind.Explicit)]
        public struct data
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct vfs
            {
                public IntPtr pVFS;
                public IntPtr file;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct memory
            {
                public byte* pData;
                public UIntPtr dataSize;
                public UIntPtr currentReadPos;
            }


        }


    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_decoder_config ma_decoder_config_init(ma_format outputFormat, uint outputChannels, uint outputSampleRate);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_decoder_config ma_decoder_config_init_default();

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_init(ma_decoder_read_proc onRead, ma_decoder_seek_proc onSeek, IntPtr pUserData, ref ma_decoder_config pConfig, IntPtr pDecoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_init_memory(IntPtr pData, UIntPtr dataSize, ref ma_decoder_config pConfig, IntPtr pDecoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_init_vfs(IntPtr pVFS, IntPtr pFilePath, ref ma_decoder_config pConfig, IntPtr pDecoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_init_vfs_w(IntPtr pVFS, string pFilePath, ref ma_decoder_config pConfig, IntPtr pDecoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_init_file(IntPtr pFilePath, ref ma_decoder_config pConfig, IntPtr pDecoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_init_file_w(string pFilePath, ref ma_decoder_config pConfig, IntPtr pDecoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_uninit(IntPtr pDecoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_read_pcm_frames(IntPtr pDecoder, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_seek_to_pcm_frame(IntPtr pDecoder, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_get_data_format(IntPtr pDecoder, IntPtr pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_get_cursor_in_pcm_frames(IntPtr pDecoder, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_get_length_in_pcm_frames(IntPtr pDecoder, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decoder_get_available_frames(IntPtr pDecoder, ref ulong pAvailableFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decode_from_vfs(IntPtr pVFS, IntPtr pFilePath, ref ma_decoder_config pConfig, ref ulong pFrameCountOut, IntPtr ppPCMFramesOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decode_file(IntPtr pFilePath, ref ma_decoder_config pConfig, ref ulong pFrameCountOut, IntPtr ppPCMFramesOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_decode_memory(IntPtr pData, UIntPtr dataSize, ref ma_decoder_config pConfig, ref ulong pFrameCountOut, IntPtr ppPCMFramesOut); // WARN_UNKNOWN_POINTER_PARAMETER

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_encoder_write_proc(ma_encoder* pEncoder, void* pBufferIn, nuint bytesToWrite, nuint* pBytesWritten);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_encoder_seek_proc(ma_encoder* pEncoder, long offset, ma_seek_origin origin);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_encoder_init_proc(ma_encoder* pEncoder);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ma_encoder_uninit_proc(ma_encoder* pEncoder);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ma_result ma_encoder_write_pcm_frames_proc(ma_encoder* pEncoder, void* pFramesIn, ulong frameCount, ulong* pFramesWritten);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_encoder_config
    {
        public ma_encoding_format encodingFormat;
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public ma_allocation_callbacks allocationCallbacks;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_encoder_config ma_encoder_config_init(ma_encoding_format encodingFormat, ma_format format, uint channels, uint sampleRate);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_encoder
    {
        public ma_encoder_config config;
        public IntPtr onWrite; // ma_encoder_write_proc
        public IntPtr onSeek; // ma_encoder_seek_proc
        public IntPtr onInit; // ma_encoder_init_proc
        public IntPtr onUninit; // ma_encoder_uninit_proc
        public IntPtr onWritePCMFrames; // ma_encoder_write_pcm_frames_proc
        public IntPtr pUserData;
        public IntPtr pInternalEncoder;
        [StructLayout(LayoutKind.Explicit)]
        public struct data
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct vfs
            {
                public IntPtr pVFS;
                public IntPtr file;
            }


        }


    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_encoder_init(ma_encoder_write_proc onWrite, ma_encoder_seek_proc onSeek, IntPtr pUserData, ref ma_encoder_config pConfig, IntPtr pEncoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_encoder_init_vfs(IntPtr pVFS, IntPtr pFilePath, ref ma_encoder_config pConfig, IntPtr pEncoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_encoder_init_vfs_w(IntPtr pVFS, string pFilePath, ref ma_encoder_config pConfig, IntPtr pEncoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_encoder_init_file(IntPtr pFilePath, ref ma_encoder_config pConfig, IntPtr pEncoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_encoder_init_file_w(string pFilePath, ref ma_encoder_config pConfig, IntPtr pEncoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_encoder_uninit(IntPtr pEncoder); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_encoder_write_pcm_frames(IntPtr pEncoder, IntPtr pFramesIn, ulong frameCount, ref ulong pFramesWritten); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_waveform_type
    {
        ma_waveform_type_sine = 0,
        ma_waveform_type_square = 1,
        ma_waveform_type_triangle = 2,
        ma_waveform_type_sawtooth = 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_waveform_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public ma_waveform_type type;
        public double amplitude;
        public double frequency;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_waveform_config ma_waveform_config_init(ma_format format, uint channels, uint sampleRate, ma_waveform_type type, double amplitude, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_waveform
    {
        public ma_data_source_base ds;
        public ma_waveform_config config;
        public double advance;
        public double time;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_waveform_init(ref ma_waveform_config pConfig, ref ma_waveform pWaveform); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_waveform_uninit(ref ma_waveform pWaveform); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_waveform_read_pcm_frames(ref ma_waveform pWaveform, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_waveform_seek_to_pcm_frame(ref ma_waveform pWaveform, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_waveform_set_amplitude(ref ma_waveform pWaveform, double amplitude); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_waveform_set_frequency(ref ma_waveform pWaveform, double frequency); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_waveform_set_type(ref ma_waveform pWaveform, ma_waveform_type type); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_waveform_set_sample_rate(ref ma_waveform pWaveform, uint sampleRate); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_pulsewave_config
    {
        public ma_format format;
        public uint channels;
        public uint sampleRate;
        public double dutyCycle;
        public double amplitude;
        public double frequency;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_pulsewave_config ma_pulsewave_config_init(ma_format format, uint channels, uint sampleRate, double dutyCycle, double amplitude, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_pulsewave
    {
        public ma_waveform waveform;
        public ma_pulsewave_config config;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pulsewave_init(ref ma_pulsewave_config pConfig, ref ma_pulsewave pWaveform); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_pulsewave_uninit(ref ma_pulsewave pWaveform); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pulsewave_read_pcm_frames(ref ma_pulsewave pWaveform, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pulsewave_seek_to_pcm_frame(ref ma_pulsewave pWaveform, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pulsewave_set_amplitude(ref ma_pulsewave pWaveform, double amplitude); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pulsewave_set_frequency(ref ma_pulsewave pWaveform, double frequency); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pulsewave_set_sample_rate(ref ma_pulsewave pWaveform, uint sampleRate); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_pulsewave_set_duty_cycle(ref ma_pulsewave pWaveform, double dutyCycle); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_noise_type
    {
        ma_noise_type_white = 0,
        ma_noise_type_pink = 1,
        ma_noise_type_brownian = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_noise_config
    {
        public ma_format format;
        public uint channels;
        public ma_noise_type type;
        public int seed;
        public double amplitude;
        public uint duplicateChannels;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_noise_config ma_noise_config_init(ma_format format, uint channels, ma_noise_type type, int seed, double amplitude);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_noise
    {
        public ma_data_source_base ds;
        public ma_noise_config config;
        public ma_lcg lcg;
        [StructLayout(LayoutKind.Explicit)]
        public struct state
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct pink
            {
                public double** bin;
                public double* accumulation;
                public uint* counter;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct brownian
            {
                public double* accumulation;
            }


        }


        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_noise_get_heap_size(ref ma_noise_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_noise_init_preallocated(ref ma_noise_config pConfig, IntPtr pHeap, ref ma_noise pNoise); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_noise_init(ref ma_noise_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_noise pNoise); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_noise_uninit(ref ma_noise pNoise, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_noise_read_pcm_frames(ref ma_noise pNoise, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_noise_set_amplitude(ref ma_noise pNoise, double amplitude); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_noise_set_seed(ref ma_noise pNoise, int seed); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_noise_set_type(ref ma_noise pNoise, ma_noise_type type); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_resource_manager_data_source_flags
    {
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_STREAM = 1,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_DECODE = 2,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_ASYNC = 4,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_WAIT_INIT = 8,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_UNKNOWN_LENGTH = 16,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_LOOPING = 32,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_pipeline_stage_notification
    {
        public IntPtr pNotification;
        public ma_fence* pFence;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_pipeline_notifications
    {
        public ma_resource_manager_pipeline_stage_notification init;
        public ma_resource_manager_pipeline_stage_notification done;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_resource_manager_pipeline_notifications ma_resource_manager_pipeline_notifications_init();

    public enum ma_resource_manager_flags
    {
        MA_RESOURCE_MANAGER_FLAG_NON_BLOCKING = 1,
        MA_RESOURCE_MANAGER_FLAG_NO_THREADING = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_data_source_config
    {
        public byte* pFilePath;
        public byte* pFilePathW;
        public ma_resource_manager_pipeline_notifications* pNotifications;
        public ulong initialSeekPointInPCMFrames;
        public ulong rangeBegInPCMFrames;
        public ulong rangeEndInPCMFrames;
        public ulong loopPointBegInPCMFrames;
        public ulong loopPointEndInPCMFrames;
        public uint flags;
        public uint isLooping;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_resource_manager_data_source_config ma_resource_manager_data_source_config_init();

    public enum ma_resource_manager_data_supply_type
    {
        ma_resource_manager_data_supply_type_unknown = 0,
        ma_resource_manager_data_supply_type_encoded = 1,
        ma_resource_manager_data_supply_type_decoded = 2,
        ma_resource_manager_data_supply_type_decoded_paged = 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_data_supply
    {
        public ma_resource_manager_data_supply_type type;
        [StructLayout(LayoutKind.Explicit)]
        public struct backend
        {
            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct encoded
            {
                public IntPtr pData;
                public UIntPtr sizeInBytes;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct decoded
            {
                public IntPtr pData;
                public ulong totalFrameCount;
                public ulong decodedFrameCount;
                public ma_format format;
                public uint channels;
                public uint sampleRate;
            }


            [FieldOffset(0)]
            [StructLayout(LayoutKind.Sequential)]
            public struct decodedPaged
            {
                public ma_paged_audio_buffer_data data;
                public ulong decodedFrameCount;
                public uint sampleRate;
            }


        }


    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_data_buffer_node
    {
        public uint hashedName32;
        public uint refCount;
        public ma_result result;
        public uint executionCounter;
        public uint executionPointer;
        public uint isDataOwnedByResourceManager;
        public ma_resource_manager_data_supply data;
        public ma_resource_manager_data_buffer_node* pParent;
        public ma_resource_manager_data_buffer_node* pChildLo;
        public ma_resource_manager_data_buffer_node* pChildHi;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_data_buffer
    {
        public ma_data_source_base ds;
        public ma_resource_manager* pResourceManager;
        public ma_resource_manager_data_buffer_node* pNode;
        public uint flags;
        public uint executionCounter;
        public uint executionPointer;
        public ulong seekTargetInPCMFrames;
        public uint seekToCursorOnNextRead;
        public ma_result result;
        public uint isLooping;
        public ma_atomic_bool32 isConnectorInitialized;
        [StructLayout(LayoutKind.Explicit)]
        public struct connector
        {
            [FieldOffset(0)]
            public ma_decoder decoder;
            [FieldOffset(0)]
            public ma_audio_buffer buffer;
            [FieldOffset(0)]
            public ma_paged_audio_buffer pagedBuffer;
        }


    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_data_stream
    {
        public ma_data_source_base ds;
        public ma_resource_manager* pResourceManager;
        public uint flags;
        public ma_decoder decoder;
        public uint isDecoderInitialized;
        public ulong totalLengthInPCMFrames;
        public uint relativeCursor;
        public ulong absoluteCursor;
        public uint currentPageIndex;
        public uint executionCounter;
        public uint executionPointer;
        public uint isLooping;
        public IntPtr pPageData;
        public fixed uint pageFrameCount[2];
        public ma_result result;
        public uint isDecoderAtEnd;
        public fixed uint isPageValid[2];
        public uint seekCounter;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_data_source
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct backend
        {
            [FieldOffset(0)]
            public ma_resource_manager_data_buffer buffer;
            [FieldOffset(0)]
            public ma_resource_manager_data_stream stream;
        }


        public uint flags;
        public uint executionCounter;
        public uint executionPointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager_config
    {
        public ma_allocation_callbacks allocationCallbacks;
        public ma_log* pLog;
        public ma_format decodedFormat;
        public uint decodedChannels;
        public uint decodedSampleRate;
        public uint jobThreadCount;
        public UIntPtr jobThreadStackSize;
        public uint jobQueueCapacity;
        public uint flags;
        public IntPtr pVFS;
        public ma_decoding_backend_vtable** ppCustomDecodingBackendVTables;
        public uint customDecodingBackendCount;
        public IntPtr pCustomDecodingBackendUserData;
        public ma_resampler_config resampling;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_resource_manager_config ma_resource_manager_config_init();

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_resource_manager
    {
        public ma_resource_manager_config config;
        public ma_resource_manager_data_buffer_node* pRootDataBufferNode;
        public IntPtr dataBufferBSTLock;
        public fixed IntPtr jobThreads[64];
        public ma_job_queue jobQueue;
        public ma_default_vfs defaultVFS;
        public ma_log log;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_init(ref ma_resource_manager_config pConfig, IntPtr pResourceManager); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_resource_manager_uninit(IntPtr pResourceManager); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_log* ma_resource_manager_get_log(IntPtr pResourceManager); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_register_file(IntPtr pResourceManager, IntPtr pFilePath, uint flags); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_register_file_w(IntPtr pResourceManager, string pFilePath, uint flags); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_register_decoded_data(IntPtr pResourceManager, IntPtr pName, IntPtr pData, ulong frameCount, ma_format format, uint channels, uint sampleRate); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_register_decoded_data_w(IntPtr pResourceManager, string pName, IntPtr pData, ulong frameCount, ma_format format, uint channels, uint sampleRate); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_register_encoded_data(IntPtr pResourceManager, IntPtr pName, IntPtr pData, UIntPtr sizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_register_encoded_data_w(IntPtr pResourceManager, string pName, IntPtr pData, UIntPtr sizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_unregister_file(IntPtr pResourceManager, IntPtr pFilePath); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_unregister_file_w(IntPtr pResourceManager, string pFilePath); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_unregister_data(IntPtr pResourceManager, IntPtr pName); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_unregister_data_w(IntPtr pResourceManager, string pName); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_init_ex(IntPtr pResourceManager, ref ma_resource_manager_data_source_config pConfig, IntPtr pDataBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_init(IntPtr pResourceManager, IntPtr pFilePath, uint flags, ref ma_resource_manager_pipeline_notifications pNotifications, IntPtr pDataBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_init_w(IntPtr pResourceManager, string pFilePath, uint flags, ref ma_resource_manager_pipeline_notifications pNotifications, IntPtr pDataBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_init_copy(IntPtr pResourceManager, IntPtr pExistingDataBuffer, IntPtr pDataBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_uninit(IntPtr pDataBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_read_pcm_frames(IntPtr pDataBuffer, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_seek_to_pcm_frame(IntPtr pDataBuffer, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_get_data_format(IntPtr pDataBuffer, IntPtr pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_get_cursor_in_pcm_frames(IntPtr pDataBuffer, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_get_length_in_pcm_frames(IntPtr pDataBuffer, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_result(IntPtr pDataBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_set_looping(IntPtr pDataBuffer, uint isLooping); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_resource_manager_data_buffer_is_looping(IntPtr pDataBuffer); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_buffer_get_available_frames(IntPtr pDataBuffer, ref ulong pAvailableFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_init_ex(IntPtr pResourceManager, ref ma_resource_manager_data_source_config pConfig, IntPtr pDataStream); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_init(IntPtr pResourceManager, IntPtr pFilePath, uint flags, ref ma_resource_manager_pipeline_notifications pNotifications, IntPtr pDataStream); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_init_w(IntPtr pResourceManager, string pFilePath, uint flags, ref ma_resource_manager_pipeline_notifications pNotifications, IntPtr pDataStream); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_uninit(IntPtr pDataStream); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_read_pcm_frames(IntPtr pDataStream, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_seek_to_pcm_frame(IntPtr pDataStream, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_get_data_format(IntPtr pDataStream, IntPtr pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_get_cursor_in_pcm_frames(IntPtr pDataStream, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_get_length_in_pcm_frames(IntPtr pDataStream, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_result(IntPtr pDataStream); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_set_looping(IntPtr pDataStream, uint isLooping); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_resource_manager_data_stream_is_looping(IntPtr pDataStream); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_stream_get_available_frames(IntPtr pDataStream, ref ulong pAvailableFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_init_ex(IntPtr pResourceManager, ref ma_resource_manager_data_source_config pConfig, IntPtr pDataSource); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_init(IntPtr pResourceManager, IntPtr pName, uint flags, ref ma_resource_manager_pipeline_notifications pNotifications, IntPtr pDataSource); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_init_w(IntPtr pResourceManager, string pName, uint flags, ref ma_resource_manager_pipeline_notifications pNotifications, IntPtr pDataSource); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_init_copy(IntPtr pResourceManager, IntPtr pExistingDataSource, IntPtr pDataSource); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_uninit(IntPtr pDataSource); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_read_pcm_frames(IntPtr pDataSource, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_seek_to_pcm_frame(IntPtr pDataSource, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_get_data_format(IntPtr pDataSource, IntPtr pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_get_cursor_in_pcm_frames(IntPtr pDataSource, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_get_length_in_pcm_frames(IntPtr pDataSource, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_result(IntPtr pDataSource); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_set_looping(IntPtr pDataSource, uint isLooping); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_resource_manager_data_source_is_looping(IntPtr pDataSource); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_data_source_get_available_frames(IntPtr pDataSource, ref ulong pAvailableFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_post_job(IntPtr pResourceManager, IntPtr pJob); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_post_job_quit(IntPtr pResourceManager); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_next_job(IntPtr pResourceManager, IntPtr pJob); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_process_job(IntPtr pResourceManager, IntPtr pJob); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_resource_manager_process_next_job(IntPtr pResourceManager); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_stack
    {
        public UIntPtr offset;
        public UIntPtr sizeInBytes;
        public fixed byte _data[1];
    }

    public enum ma_node_flags
    {
        MA_NODE_FLAG_PASSTHROUGH = 1,
        MA_NODE_FLAG_CONTINUOUS_PROCESSING = 2,
        MA_NODE_FLAG_ALLOW_NULL_INPUT = 4,
        MA_NODE_FLAG_DIFFERENT_PROCESSING_RATES = 8,
        MA_NODE_FLAG_SILENT_OUTPUT = 16,
    }

    public enum ma_node_state
    {
        ma_node_state_started = 0,
        ma_node_state_stopped = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_node_vtable
    {
        public IntPtr onProcess; // WARN_ANONYMOUS_FUNCTION_POINTER
        public IntPtr onGetRequiredInputFrameCount; // WARN_ANONYMOUS_FUNCTION_POINTER
        public byte inputBusCount;
        public byte outputBusCount;
        public uint flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_node_config
    {
        public ma_node_vtable* vtable;
        public ma_node_state initialState;
        public uint inputBusCount;
        public uint outputBusCount;
        public uint* pInputChannels;
        public uint* pOutputChannels;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_node_config ma_node_config_init();

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_node_output_bus
    {
        public IntPtr pNode;
        public byte outputBusIndex;
        public byte channels;
        public byte inputNodeInputBusIndex;
        public uint flags;
        public uint refCount;
        public uint isAttached;
        public uint @lock;
        public float volume;
        public ma_node_output_bus* pNext;
        public ma_node_output_bus* pPrev;
        public IntPtr pInputNode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_node_input_bus
    {
        public ma_node_output_bus head;
        public uint nextCounter;
        public uint @lock;
        public byte channels;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_node_base
    {
        public ma_node_graph* pNodeGraph;
        public ma_node_vtable* vtable;
        public uint inputBusCount;
        public uint outputBusCount;
        public ma_node_input_bus* pInputBuses;
        public ma_node_output_bus* pOutputBuses;
        public float* pCachedData;
        public ushort cachedDataCapInFramesPerBus;
        public ushort cachedFrameCountOut;
        public ushort cachedFrameCountIn;
        public ushort consumedFrameCountIn;
        public ma_node_state state;
        public fixed ulong stateTimes[2];
        public ulong localTime;
        public ma_node_input_bus__InlineArray _inputBuses;
        [InlineArray(2)]
        public partial struct ma_node_input_bus__InlineArray
        {
            public ma_node_input_bus _value;
        }

        public ma_node_output_bus__InlineArray _outputBuses;
        [InlineArray(2)]
        public partial struct ma_node_output_bus__InlineArray
        {
            public ma_node_output_bus _value;
        }

        public IntPtr _pHeap;
        public uint _ownsHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_get_heap_size(ref ma_node_graph pNodeGraph, ref ma_node_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_init_preallocated(ref ma_node_graph pNodeGraph, ref ma_node_config pConfig, IntPtr pHeap, IntPtr pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_init(ref ma_node_graph pNodeGraph, ref ma_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, IntPtr pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_node_uninit(IntPtr pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_node_graph* ma_node_get_node_graph(IntPtr pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_node_get_input_bus_count(IntPtr pNode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_node_get_output_bus_count(IntPtr pNode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_node_get_input_channels(IntPtr pNode, uint inputBusIndex);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_node_get_output_channels(IntPtr pNode, uint outputBusIndex);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_attach_output_bus(IntPtr pNode, uint outputBusIndex, IntPtr pOtherNode, uint otherNodeInputBusIndex);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_detach_output_bus(IntPtr pNode, uint outputBusIndex);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_detach_all_output_buses(IntPtr pNode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_set_output_bus_volume(IntPtr pNode, uint outputBusIndex, float volume);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_node_get_output_bus_volume(IntPtr pNode, uint outputBusIndex);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_set_state(IntPtr pNode, ma_node_state state);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_node_state ma_node_get_state(IntPtr pNode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_set_state_time(IntPtr pNode, ma_node_state state, ulong globalTime);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_node_get_state_time(IntPtr pNode, ma_node_state state);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_node_state ma_node_get_state_by_time(IntPtr pNode, ulong globalTime);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_node_state ma_node_get_state_by_time_range(IntPtr pNode, ulong globalTimeBeg, ulong globalTimeEnd);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_node_get_time(IntPtr pNode);

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_set_time(IntPtr pNode, ulong localTime);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_node_graph_config
    {
        public uint channels;
        public uint processingSizeInFrames;
        public UIntPtr preMixStackSizeInBytes;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_node_graph_config ma_node_graph_config_init(uint channels);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_node_graph
    {
        public ma_node_base @base;
        public ma_node_base endpoint;
        public float* pProcessingCache;
        public uint processingCacheFramesRemaining;
        public uint processingSizeInFrames;
        public uint isReading;
        public ma_stack* pPreMixStack;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_graph_init(ref ma_node_graph_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, IntPtr pNodeGraph); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_node_graph_uninit(IntPtr pNodeGraph, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_node_graph_get_endpoint(IntPtr pNodeGraph); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_graph_read_pcm_frames(IntPtr pNodeGraph, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_node_graph_get_channels(IntPtr pNodeGraph); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_node_graph_get_time(IntPtr pNodeGraph); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_node_graph_set_time(IntPtr pNodeGraph, ulong globalTime); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_node_graph_get_processing_size_in_frames(IntPtr pNodeGraph); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_data_source_node_config
    {
        public ma_node_config nodeConfig;
        public IntPtr pDataSource;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_data_source_node_config ma_data_source_node_config_init(IntPtr pDataSource);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_data_source_node
    {
        public ma_node_base @base;
        public IntPtr pDataSource;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_node_init(IntPtr pNodeGraph, ref ma_data_source_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_data_source_node pDataSourceNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_data_source_node_uninit(ref ma_data_source_node pDataSourceNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_data_source_node_set_looping(ref ma_data_source_node pDataSourceNode, uint isLooping); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_data_source_node_is_looping(ref ma_data_source_node pDataSourceNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_splitter_node_config
    {
        public ma_node_config nodeConfig;
        public uint channels;
        public uint outputBusCount;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_splitter_node_config ma_splitter_node_config_init(uint channels);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_splitter_node
    {
        public ma_node_base @base;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_splitter_node_init(IntPtr pNodeGraph, ref ma_splitter_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_splitter_node pSplitterNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_splitter_node_uninit(ref ma_splitter_node pSplitterNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_biquad_node_config
    {
        public ma_node_config nodeConfig;
        public ma_biquad_config biquad;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_biquad_node_config ma_biquad_node_config_init(uint channels, float b0, float b1, float b2, float a0, float a1, float a2);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_biquad_node
    {
        public ma_node_base baseNode;
        public ma_biquad biquad;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_biquad_node_init(IntPtr pNodeGraph, ref ma_biquad_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_biquad_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_biquad_node_reinit(ref ma_biquad_config pConfig, ref ma_biquad_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_biquad_node_uninit(ref ma_biquad_node pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lpf_node_config
    {
        public ma_node_config nodeConfig;
        public ma_lpf_config lpf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_lpf_node_config ma_lpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_lpf_node
    {
        public ma_node_base baseNode;
        public ma_lpf lpf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf_node_init(IntPtr pNodeGraph, ref ma_lpf_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_lpf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_lpf_node_reinit(ref ma_lpf_config pConfig, ref ma_lpf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_lpf_node_uninit(ref ma_lpf_node pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hpf_node_config
    {
        public ma_node_config nodeConfig;
        public ma_hpf_config hpf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_hpf_node_config ma_hpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hpf_node
    {
        public ma_node_base baseNode;
        public ma_hpf hpf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf_node_init(IntPtr pNodeGraph, ref ma_hpf_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_hpf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hpf_node_reinit(ref ma_hpf_config pConfig, ref ma_hpf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_hpf_node_uninit(ref ma_hpf_node pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_bpf_node_config
    {
        public ma_node_config nodeConfig;
        public ma_bpf_config bpf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_bpf_node_config ma_bpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_bpf_node
    {
        public ma_node_base baseNode;
        public ma_bpf bpf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf_node_init(IntPtr pNodeGraph, ref ma_bpf_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_bpf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_bpf_node_reinit(ref ma_bpf_config pConfig, ref ma_bpf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_bpf_node_uninit(ref ma_bpf_node pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_notch_node_config
    {
        public ma_node_config nodeConfig;
        public ma_notch2_config notch;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_notch_node_config ma_notch_node_config_init(uint channels, uint sampleRate, double q, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_notch_node
    {
        public ma_node_base baseNode;
        public ma_notch2 notch;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_notch_node_init(IntPtr pNodeGraph, ref ma_notch_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_notch_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_notch_node_reinit(ref ma_notch2_config pConfig, ref ma_notch_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_notch_node_uninit(ref ma_notch_node pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_peak_node_config
    {
        public ma_node_config nodeConfig;
        public ma_peak2_config peak;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_peak_node_config ma_peak_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_peak_node
    {
        public ma_node_base baseNode;
        public ma_peak2 peak;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_peak_node_init(IntPtr pNodeGraph, ref ma_peak_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_peak_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_peak_node_reinit(ref ma_peak2_config pConfig, ref ma_peak_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_peak_node_uninit(ref ma_peak_node pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_loshelf_node_config
    {
        public ma_node_config nodeConfig;
        public ma_loshelf2_config loshelf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_loshelf_node_config ma_loshelf_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_loshelf_node
    {
        public ma_node_base baseNode;
        public ma_loshelf2 loshelf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_loshelf_node_init(IntPtr pNodeGraph, ref ma_loshelf_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_loshelf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_loshelf_node_reinit(ref ma_loshelf2_config pConfig, ref ma_loshelf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_loshelf_node_uninit(ref ma_loshelf_node pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hishelf_node_config
    {
        public ma_node_config nodeConfig;
        public ma_hishelf2_config hishelf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_hishelf_node_config ma_hishelf_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_hishelf_node
    {
        public ma_node_base baseNode;
        public ma_hishelf2 hishelf;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hishelf_node_init(IntPtr pNodeGraph, ref ma_hishelf_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_hishelf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_hishelf_node_reinit(ref ma_hishelf2_config pConfig, ref ma_hishelf_node pNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_hishelf_node_uninit(ref ma_hishelf_node pNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_delay_node_config
    {
        public ma_node_config nodeConfig;
        public ma_delay_config delay;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_delay_node_config ma_delay_node_config_init(uint channels, uint sampleRate, uint delayInFrames, float decay);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_delay_node
    {
        public ma_node_base baseNode;
        public ma_delay delay;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_delay_node_init(IntPtr pNodeGraph, ref ma_delay_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_delay_node pDelayNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_delay_node_uninit(ref ma_delay_node pDelayNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_delay_node_set_wet(ref ma_delay_node pDelayNode, float value); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_delay_node_get_wet(ref ma_delay_node pDelayNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_delay_node_set_dry(ref ma_delay_node pDelayNode, float value); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_delay_node_get_dry(ref ma_delay_node pDelayNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_delay_node_set_decay(ref ma_delay_node pDelayNode, float value); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_delay_node_get_decay(ref ma_delay_node pDelayNode); // WARN_UNKNOWN_POINTER_PARAMETER

    public enum ma_sound_flags
    {
        MA_SOUND_FLAG_STREAM = 1,
        MA_SOUND_FLAG_DECODE = 2,
        MA_SOUND_FLAG_ASYNC = 4,
        MA_SOUND_FLAG_WAIT_INIT = 8,
        MA_SOUND_FLAG_UNKNOWN_LENGTH = 16,
        MA_SOUND_FLAG_LOOPING = 32,
        MA_SOUND_FLAG_NO_DEFAULT_ATTACHMENT = 4096,
        MA_SOUND_FLAG_NO_PITCH = 8192,
        MA_SOUND_FLAG_NO_SPATIALIZATION = 16384,
    }

    public enum ma_engine_node_type
    {
        ma_engine_node_type_sound = 0,
        ma_engine_node_type_group = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_engine_node_config
    {
        public ma_engine* pEngine;
        public ma_engine_node_type type;
        public uint channelsIn;
        public uint channelsOut;
        public uint sampleRate;
        public uint volumeSmoothTimeInPCMFrames;
        public ma_mono_expansion_mode monoExpansionMode;
        public byte isPitchDisabled;
        public byte isSpatializationDisabled;
        public byte pinnedListenerIndex;
        public ma_resampler_config resampling;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_engine_node_config ma_engine_node_config_init(ref ma_engine pEngine, ma_engine_node_type type, uint flags); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_engine_node
    {
        public ma_node_base baseNode;
        public ma_engine* pEngine;
        public uint sampleRate;
        public uint volumeSmoothTimeInPCMFrames;
        public ma_mono_expansion_mode monoExpansionMode;
        public ma_fader fader;
        public ma_resampler resampler;
        public ma_spatializer spatializer;
        public ma_panner panner;
        public ma_gainer volumeGainer;
        public ma_atomic_float volume;
        public float pitch;
        public float oldPitch;
        public float oldDopplerPitch;
        public uint isPitchDisabled;
        public uint isSpatializationDisabled;
        public uint pinnedListenerIndex;
        [StructLayout(LayoutKind.Sequential)]
        public struct fadeSettings
        {
            public ma_atomic_float volumeBeg;
            public ma_atomic_float volumeEnd;
            public ma_atomic_uint64 fadeLengthInFrames;
            public ma_atomic_uint64 absoluteGlobalTimeInFrames;
        }


        public byte _ownsHeap;
        public IntPtr _pHeap;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_node_get_heap_size(ref ma_engine_node_config pConfig, IntPtr pHeapSizeInBytes); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_node_init_preallocated(ref ma_engine_node_config pConfig, IntPtr pHeap, ref ma_engine_node pEngineNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_node_init(ref ma_engine_node_config pConfig, ref ma_allocation_callbacks pAllocationCallbacks, ref ma_engine_node pEngineNode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_node_uninit(ref ma_engine_node pEngineNode, ref ma_allocation_callbacks pAllocationCallbacks); // WARN_UNKNOWN_POINTER_PARAMETER

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ma_sound_end_proc(void* pUserData, ma_sound* pSound);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_sound_config
    {
        public byte* pFilePath;
        public byte* pFilePathW;
        public IntPtr pDataSource;
        public IntPtr pInitialAttachment;
        public uint initialAttachmentInputBusIndex;
        public uint channelsIn;
        public uint channelsOut;
        public ma_mono_expansion_mode monoExpansionMode;
        public uint flags;
        public uint volumeSmoothTimeInPCMFrames;
        public ulong initialSeekPointInPCMFrames;
        public ulong rangeBegInPCMFrames;
        public ulong rangeEndInPCMFrames;
        public ulong loopPointBegInPCMFrames;
        public ulong loopPointEndInPCMFrames;
        public IntPtr endCallback; // ma_sound_end_proc
        public IntPtr pEndCallbackUserData;
        public ma_resampler_config pitchResampling;
        public ma_resource_manager_pipeline_notifications initNotifications;
        public ma_fence* pDoneFence;
        public uint isLooping;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_sound_config ma_sound_config_init();

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_sound_config ma_sound_config_init_2(ref ma_engine pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_sound
    {
        public ma_engine_node engineNode;
        public IntPtr pDataSource;
        public ulong seekTarget;
        public uint atEnd;
        public IntPtr endCallback; // ma_sound_end_proc
        public IntPtr pEndCallbackUserData;
        public float* pProcessingCache;
        public uint processingCacheFramesRemaining;
        public uint processingCacheCap;
        public byte ownsDataSource;
        public ma_resource_manager_data_source* pResourceManagerDataSource;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_sound_inlined
    {
        public ma_sound sound;
        public ma_sound_inlined* pNext;
        public ma_sound_inlined* pPrev;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_sound_config ma_sound_group_config_init();

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_sound_config ma_sound_group_config_init_2(ref ma_engine pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ma_engine_process_proc(void* pUserData, float* pFramesOut, ulong frameCount);

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_engine_config
    {
        public ma_resource_manager* pResourceManager;
        public ma_context* pContext;
        public ma_device* pDevice;
        public * pPlaybackDeviceID;
        public IntPtr dataCallback; // ma_device_data_proc
        public IntPtr notificationCallback; // ma_device_notification_proc
        public ma_log* pLog;
        public uint listenerCount;
        public uint channels;
        public uint sampleRate;
        public uint periodSizeInFrames;
        public uint periodSizeInMilliseconds;
        public uint gainSmoothTimeInFrames;
        public uint gainSmoothTimeInMilliseconds;
        public uint defaultVolumeSmoothTimeInPCMFrames;
        public uint preMixStackSizeInBytes;
        public ma_allocation_callbacks allocationCallbacks;
        public uint noAutoStart;
        public uint noDevice;
        public ma_mono_expansion_mode monoExpansionMode;
        public IntPtr pResourceManagerVFS;
        public IntPtr onProcess; // ma_engine_process_proc
        public IntPtr pProcessUserData;
        public ma_resampler_config resourceManagerResampling;
        public ma_resampler_config pitchResampling;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_engine_config ma_engine_config_init();

    [StructLayout(LayoutKind.Sequential)]
    public struct ma_engine
    {
        public ma_node_graph nodeGraph;
        public ma_resource_manager* pResourceManager;
        public ma_device* pDevice;
        public ma_log* pLog;
        public uint sampleRate;
        public uint listenerCount;
        public ma_spatializer_listener__InlineArray listeners;
        [InlineArray(4)]
        public partial struct ma_spatializer_listener__InlineArray
        {
            public ma_spatializer_listener _value;
        }

        public ma_allocation_callbacks allocationCallbacks;
        public byte ownsResourceManager;
        public byte ownsDevice;
        public uint inlinedSoundLock;
        public ma_sound_inlined* pInlinedSoundHead;
        public uint inlinedSoundCount;
        public uint gainSmoothTimeInFrames;
        public uint defaultVolumeSmoothTimeInPCMFrames;
        public ma_mono_expansion_mode monoExpansionMode;
        public IntPtr onProcess; // ma_engine_process_proc
        public IntPtr pProcessUserData;
        public ma_resampler_config pitchResamplingConfig;
    }

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_init(ref ma_engine_config pConfig, IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_uninit(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_read_pcm_frames(IntPtr pEngine, IntPtr pFramesOut, ulong frameCount, ref ulong pFramesRead); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_engine_get_node_graph(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_engine_get_resource_manager(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_engine_get_device(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_log* ma_engine_get_log(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_engine_get_endpoint(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_engine_get_time_in_pcm_frames(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_engine_get_time_in_milliseconds(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_set_time_in_pcm_frames(IntPtr pEngine, ulong globalTime); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_set_time_in_milliseconds(IntPtr pEngine, ulong globalTime); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_engine_get_time(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_set_time(IntPtr pEngine, ulong globalTime); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_engine_get_channels(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_engine_get_sample_rate(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_start(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_stop(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_set_volume(IntPtr pEngine, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_engine_get_volume(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_set_gain_db(IntPtr pEngine, float gainDB); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_engine_get_gain_db(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_engine_get_listener_count(IntPtr pEngine); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_engine_find_closest_listener(IntPtr pEngine, float absolutePosX, float absolutePosY, float absolutePosZ); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_listener_set_position(IntPtr pEngine, uint listenerIndex, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_engine_listener_get_position(IntPtr pEngine, uint listenerIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_listener_set_direction(IntPtr pEngine, uint listenerIndex, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_engine_listener_get_direction(IntPtr pEngine, uint listenerIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_listener_set_velocity(IntPtr pEngine, uint listenerIndex, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_engine_listener_get_velocity(IntPtr pEngine, uint listenerIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_listener_set_cone(IntPtr pEngine, uint listenerIndex, float innerAngleInRadians, float outerAngleInRadians, float outerGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_listener_get_cone(IntPtr pEngine, uint listenerIndex, IntPtr pInnerAngleInRadians, IntPtr pOuterAngleInRadians, IntPtr pOuterGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_listener_set_world_up(IntPtr pEngine, uint listenerIndex, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_engine_listener_get_world_up(IntPtr pEngine, uint listenerIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_engine_listener_set_enabled(IntPtr pEngine, uint listenerIndex, uint isEnabled); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_engine_listener_is_enabled(IntPtr pEngine, uint listenerIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_play_sound_ex(IntPtr pEngine, IntPtr pFilePath, IntPtr pNode, uint nodeInputBusIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_engine_play_sound(IntPtr pEngine, IntPtr pFilePath, ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_init_from_file(IntPtr pEngine, IntPtr pFilePath, uint flags, ref ma_sound pGroup, ref ma_fence pDoneFence, IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_init_from_file_w(IntPtr pEngine, string pFilePath, uint flags, ref ma_sound pGroup, ref ma_fence pDoneFence, IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_init_copy(IntPtr pEngine, IntPtr pExistingSound, uint flags, ref ma_sound pGroup, IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_init_from_data_source(IntPtr pEngine, IntPtr pDataSource, uint flags, ref ma_sound pGroup, IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_init_ex(IntPtr pEngine, ref ma_sound_config pConfig, IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_uninit(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_sound_get_engine(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_sound_get_data_source(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_start(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_stop(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_stop_with_fade_in_pcm_frames(IntPtr pSound, ulong fadeLengthInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_stop_with_fade_in_milliseconds(IntPtr pSound, ulong fadeLengthInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_reset_start_time(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_reset_stop_time(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_reset_fade(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_reset_stop_time_and_fade(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_volume(IntPtr pSound, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_volume(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_pan(IntPtr pSound, float pan); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_pan(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_pan_mode(IntPtr pSound, ma_pan_mode panMode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_pan_mode ma_sound_get_pan_mode(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_pitch(IntPtr pSound, float pitch); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_pitch(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_spatialization_enabled(IntPtr pSound, uint enabled); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_is_spatialization_enabled(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_pinned_listener_index(IntPtr pSound, uint listenerIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_get_pinned_listener_index(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_get_listener_index(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_sound_get_direction_to_listener(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_position(IntPtr pSound, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_sound_get_position(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_direction(IntPtr pSound, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_sound_get_direction(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_velocity(IntPtr pSound, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_sound_get_velocity(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_attenuation_model(IntPtr pSound, ma_attenuation_model attenuationModel); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_attenuation_model ma_sound_get_attenuation_model(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_positioning(IntPtr pSound, ma_positioning positioning); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_positioning ma_sound_get_positioning(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_rolloff(IntPtr pSound, float rolloff); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_rolloff(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_min_gain(IntPtr pSound, float minGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_min_gain(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_max_gain(IntPtr pSound, float maxGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_max_gain(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_min_distance(IntPtr pSound, float minDistance); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_min_distance(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_max_distance(IntPtr pSound, float maxDistance); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_max_distance(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_cone(IntPtr pSound, float innerAngleInRadians, float outerAngleInRadians, float outerGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_get_cone(IntPtr pSound, IntPtr pInnerAngleInRadians, IntPtr pOuterAngleInRadians, IntPtr pOuterGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_doppler_factor(IntPtr pSound, float dopplerFactor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_doppler_factor(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_directional_attenuation_factor(IntPtr pSound, float directionalAttenuationFactor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_directional_attenuation_factor(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_fade_in_pcm_frames(IntPtr pSound, float volumeBeg, float volumeEnd, ulong fadeLengthInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_fade_in_milliseconds(IntPtr pSound, float volumeBeg, float volumeEnd, ulong fadeLengthInMilliseconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_fade_start_in_pcm_frames(IntPtr pSound, float volumeBeg, float volumeEnd, ulong fadeLengthInFrames, ulong absoluteGlobalTimeInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_fade_start_in_milliseconds(IntPtr pSound, float volumeBeg, float volumeEnd, ulong fadeLengthInMilliseconds, ulong absoluteGlobalTimeInMilliseconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_get_current_fade_volume(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_start_time_in_pcm_frames(IntPtr pSound, ulong absoluteGlobalTimeInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_start_time_in_milliseconds(IntPtr pSound, ulong absoluteGlobalTimeInMilliseconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_stop_time_in_pcm_frames(IntPtr pSound, ulong absoluteGlobalTimeInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_stop_time_in_milliseconds(IntPtr pSound, ulong absoluteGlobalTimeInMilliseconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_stop_time_with_fade_in_pcm_frames(IntPtr pSound, ulong stopAbsoluteGlobalTimeInFrames, ulong fadeLengthInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_stop_time_with_fade_in_milliseconds(IntPtr pSound, ulong stopAbsoluteGlobalTimeInMilliseconds, ulong fadeLengthInMilliseconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_is_playing(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_sound_get_time_in_pcm_frames(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_sound_get_time_in_milliseconds(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_set_looping(IntPtr pSound, uint isLooping); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_is_looping(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_at_end(IntPtr pSound); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_seek_to_pcm_frame(IntPtr pSound, ulong frameIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_seek_to_second(IntPtr pSound, float seekPointInSeconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_get_data_format(IntPtr pSound, IntPtr pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, UIntPtr channelMapCap); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_get_cursor_in_pcm_frames(IntPtr pSound, ref ulong pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_get_length_in_pcm_frames(IntPtr pSound, ref ulong pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_get_cursor_in_seconds(IntPtr pSound, IntPtr pCursor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_get_length_in_seconds(IntPtr pSound, IntPtr pLength); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_set_end_callback(IntPtr pSound, ma_sound_end_proc callback, IntPtr pUserData); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_group_init(IntPtr pEngine, uint flags, ref ma_sound pParentGroup, ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_group_init_ex(IntPtr pEngine, ref ma_sound_config pConfig, ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_uninit(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr ma_sound_group_get_engine(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_group_start(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_result ma_sound_group_stop(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_volume(ref ma_sound pGroup, float volume); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_volume(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_pan(ref ma_sound pGroup, float pan); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_pan(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_pan_mode(ref ma_sound pGroup, ma_pan_mode panMode); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_pan_mode ma_sound_group_get_pan_mode(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_pitch(ref ma_sound pGroup, float pitch); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_pitch(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_spatialization_enabled(ref ma_sound pGroup, uint enabled); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_group_is_spatialization_enabled(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_pinned_listener_index(ref ma_sound pGroup, uint listenerIndex); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_group_get_pinned_listener_index(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_group_get_listener_index(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_sound_group_get_direction_to_listener(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_position(ref ma_sound pGroup, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_sound_group_get_position(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_direction(ref ma_sound pGroup, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_sound_group_get_direction(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_velocity(ref ma_sound pGroup, float x, float y, float z); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_vec3f ma_sound_group_get_velocity(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_attenuation_model(ref ma_sound pGroup, ma_attenuation_model attenuationModel); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_attenuation_model ma_sound_group_get_attenuation_model(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_positioning(ref ma_sound pGroup, ma_positioning positioning); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ma_positioning ma_sound_group_get_positioning(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_rolloff(ref ma_sound pGroup, float rolloff); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_rolloff(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_min_gain(ref ma_sound pGroup, float minGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_min_gain(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_max_gain(ref ma_sound pGroup, float maxGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_max_gain(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_min_distance(ref ma_sound pGroup, float minDistance); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_min_distance(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_max_distance(ref ma_sound pGroup, float maxDistance); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_max_distance(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_cone(ref ma_sound pGroup, float innerAngleInRadians, float outerAngleInRadians, float outerGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_get_cone(ref ma_sound pGroup, IntPtr pInnerAngleInRadians, IntPtr pOuterAngleInRadians, IntPtr pOuterGain); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_doppler_factor(ref ma_sound pGroup, float dopplerFactor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_doppler_factor(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_directional_attenuation_factor(ref ma_sound pGroup, float directionalAttenuationFactor); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_directional_attenuation_factor(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_fade_in_pcm_frames(ref ma_sound pGroup, float volumeBeg, float volumeEnd, ulong fadeLengthInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_fade_in_milliseconds(ref ma_sound pGroup, float volumeBeg, float volumeEnd, ulong fadeLengthInMilliseconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float ma_sound_group_get_current_fade_volume(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_start_time_in_pcm_frames(ref ma_sound pGroup, ulong absoluteGlobalTimeInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_start_time_in_milliseconds(ref ma_sound pGroup, ulong absoluteGlobalTimeInMilliseconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_stop_time_in_pcm_frames(ref ma_sound pGroup, ulong absoluteGlobalTimeInFrames); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ma_sound_group_set_stop_time_in_milliseconds(ref ma_sound pGroup, ulong absoluteGlobalTimeInMilliseconds); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint ma_sound_group_is_playing(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER

    [LibraryImport(nativeLibName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ulong ma_sound_group_get_time_in_pcm_frames(ref ma_sound pGroup); // WARN_UNKNOWN_POINTER_PARAMETER


}
