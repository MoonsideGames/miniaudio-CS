namespace GenerateBindings;

internal static class UserProvidedData
{
    internal enum PointerFunctionDataIntent
    {
        Unknown,
        IntPtr,
        Ref,
        Out,
        Array,
        OutArray,
        Pointer,
        In,
    }

    internal struct DelegateDefinition
    {
        public string ReturnType { get; set; }
        public (string, string)[] Parameters { get; set; }
    }

    internal static readonly Dictionary<(string, string), PointerFunctionDataIntent> PointerFunctionDataIntents = new()
    {
        { ("ma_biquad_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4633:18
        { ("ma_lpf1_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4672:18
        { ("ma_lpf2_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4686:18
        { ("ma_lpf_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4722:18
        { ("ma_hpf1_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4761:18
        { ("ma_hpf2_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4774:18
        { ("ma_hpf_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4809:18
        { ("ma_bpf2_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4839:18
        { ("ma_bpf_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4871:18
        { ("ma_notch2_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4901:18
        { ("ma_peak2_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4932:18
        { ("ma_loshelf2_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4963:18
        { ("ma_hishelf2_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4994:18
        { ("ma_gainer_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5063:18
        { ("ma_gainer_set_gains", "pNewGains"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5069:18
        { ("ma_gainer_get_master_volume", "pVolume"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5071:18
        { ("ma_fader_get_data_format", "pFormat"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5131:13
        { ("ma_spatializer_listener_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5201:18
        { ("ma_spatializer_listener_get_cone", "pInnerAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5207:13
        { ("ma_spatializer_listener_get_cone", "pOuterAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5207:13
        { ("ma_spatializer_listener_get_cone", "pOuterGain"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5207:13
        { ("ma_spatializer_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5279:18
        { ("ma_spatializer_get_master_volume", "pVolume"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5285:18
        { ("ma_spatializer_get_cone", "pInnerAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5303:13
        { ("ma_spatializer_get_cone", "pOuterAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5303:13
        { ("ma_spatializer_get_cone", "pOuterGain"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5303:13
        { ("ma_linear_resampler_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5370:18
        { ("ma_resampler_get_heap_size", "pConfig"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5443:18
        { ("ma_resampler_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5443:18
        { ("ma_resampler_init_preallocated", "pConfig"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5444:18
        { ("ma_resampler_init", "pConfig"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5449:18
        { ("ma_channel_converter_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5582:18
        { ("ma_data_converter_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5651:18
        { ("ma_deinterleave_pcm_frames", "ppDeinterleavedPCMFrames"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5698:13
        { ("ma_interleave_pcm_frames", "ppDeinterleavedPCMFrames"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5703:13
        { ("ma_data_source_seek_seconds", "pSecondsSeeked"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5879:18
        { ("ma_data_source_get_data_format", "pFormat"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5881:18
        { ("ma_data_source_get_cursor_in_seconds", "pCursor"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5884:18
        { ("ma_data_source_get_length_in_seconds", "pLength"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5885:18
        { ("ma_audio_buffer_ref_map", "ppFramesOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5916:18
        { ("ma_audio_buffer_alloc_and_init", "ppAudioBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5947:18
        { ("ma_audio_buffer_map", "ppFramesOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5952:18
        { ("ma_paged_audio_buffer_data_get_head", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5989:36
        { ("ma_paged_audio_buffer_data_get_tail", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5990:36
        { ("ma_paged_audio_buffer_data_allocate_page", "ppPage"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5992:18
        { ("ma_paged_audio_buffer_data_free_page", "pPage"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5993:18
        { ("ma_paged_audio_buffer_data_append_page", "pPage"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5994:18
        { ("ma_rb_acquire_read", "pSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6046:18
        { ("ma_rb_acquire_read", "ppBufferOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6046:18
        { ("ma_rb_acquire_write", "pSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6048:18
        { ("ma_rb_acquire_write", "ppBufferOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6048:18
        { ("ma_pcm_rb_acquire_read", "ppBufferOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6074:18
        { ("ma_pcm_rb_acquire_write", "ppBufferOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6076:18
        { ("ma_blend_f32", "pOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6160:13
        { ("ma_blend_f32", "pInA"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6160:13
        { ("ma_blend_f32", "pInB"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6160:13
        { ("ma_slot_allocator_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6381:18
        { ("ma_job_process", "pJob"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6541:18
        { ("ma_job_queue_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6584:18
        { ("ma_job_queue_post", "pJob"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6588:18
        { ("ma_job_queue_next", "pJob"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6589:18
        { ("ma_device_job_thread_post", "pJob"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6770:18
        { ("ma_device_job_thread_next", "pJob"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6771:18
        { ("ma_context_init", "backends"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8317:18
        { ("ma_context_init", "pConfig"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8317:18
        { ("ma_context_init", "pContext"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8317:18
        { ("ma_context_uninit", "pContext"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8342:18
        { ("ma_context_get_log", "pContext"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8368:16
        { ("ma_context_enumerate_devices", "pContext"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8435:18
        { ("ma_context_get_devices", "pContext"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8490:18
        { ("ma_context_get_devices", "ppPlaybackDeviceInfos"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8490:18
        { ("ma_context_get_devices", "ppCaptureDeviceInfos"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8490:18
        { ("ma_context_get_device_info", "pContext"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8532:18
        { ("ma_context_is_loopback_supported", "pContext"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8548:18
        { ("ma_device_init", "pContext"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8949:18
        { ("ma_device_init", "pConfig"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8949:18
        { ("ma_device_init", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:8949:18
        { ("ma_device_init_ex", "backends"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9007:18
        { ("ma_device_init_ex", "pContextConfig"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9007:18
        { ("ma_device_init_ex", "pConfig"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9007:18
        { ("ma_device_init_ex", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9007:18
        { ("ma_device_uninit", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9041:13
        { ("ma_device_get_context", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9047:20
        { ("ma_device_get_context", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9047:20
        { ("ma_device_get_log", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9052:16
        { ("ma_device_get_info", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9088:18
        { ("ma_device_get_name", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9141:18
        { ("ma_device_get_name", "pLengthNotIncludingNullTerminator"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9141:18
        { ("ma_device_start", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9185:18
        { ("ma_device_stop", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9231:18
        { ("ma_device_is_started", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9264:18
        { ("ma_device_get_state", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9319:24
        { ("ma_device_post_init", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9368:18
        { ("ma_device_set_master_volume", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9417:18
        { ("ma_device_get_master_volume", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9460:18
        { ("ma_device_get_master_volume", "pVolume"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9460:18
        { ("ma_device_set_master_volume_db", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9507:18
        { ("ma_device_get_master_volume_db", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9550:18
        { ("ma_device_get_master_volume_db", "pGainDB"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9550:18
        { ("ma_device_handle_backend_data_callback", "pDevice"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9598:18
        { ("ma_get_backend_from_name", "pBackend"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9663:18
        { ("ma_get_enabled_backends", "pBackends"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9741:18
        { ("ma_get_enabled_backends", "pBackendCount"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9741:18
        { ("ma_offset_pcm_frames_ptr_f32", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9789:25
        { ("ma_offset_pcm_frames_ptr_f32", "p"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9789:25
        { ("ma_offset_pcm_frames_const_ptr_f32", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9790:31
        { ("ma_offset_pcm_frames_const_ptr_f32", "p"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9790:31
        { ("ma_clip_samples_f32", "pDst"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9800:13
        { ("ma_clip_samples_f32", "pSrc"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9800:13
        { ("ma_copy_and_apply_volume_factor_f32", "pSamplesOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9812:13
        { ("ma_copy_and_apply_volume_factor_f32", "pSamplesIn"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9812:13
        { ("ma_apply_volume_factor_f32", "pSamples"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9818:13
        { ("ma_copy_and_apply_volume_factor_pcm_frames_f32", "pFramesOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9824:13
        { ("ma_copy_and_apply_volume_factor_pcm_frames_f32", "pFramesIn"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9824:13
        { ("ma_apply_volume_factor_pcm_frames_f32", "pFrames"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9831:13
        { ("ma_copy_and_apply_volume_factor_per_channel_f32", "pFramesOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9834:13
        { ("ma_copy_and_apply_volume_factor_per_channel_f32", "pFramesIn"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9834:13
        { ("ma_copy_and_apply_volume_factor_per_channel_f32", "pChannelGains"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9834:13
        { ("ma_copy_and_apply_volume_and_clip_samples_f32", "pDst"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9841:13
        { ("ma_copy_and_apply_volume_and_clip_samples_f32", "pSrc"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9841:13
        { ("ma_mix_pcm_frames_f32", "pDst"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9861:18
        { ("ma_mix_pcm_frames_f32", "pSrc"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9861:18
        { ("ma_vfs_read", "pBytesRead"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9911:18
        { ("ma_vfs_write", "pBytesWritten"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9912:18
        { ("ma_vfs_open_and_read_file", "ppData"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9916:18
        { ("ma_vfs_open_and_read_file", "pSize"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9916:18
        { ("ma_decoder_init", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10037:18
        { ("ma_decoder_init_memory", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10038:18
        { ("ma_decoder_init_vfs", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10039:18
        { ("ma_decoder_init_vfs_w", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10040:18
        { ("ma_decoder_init_file", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10041:18
        { ("ma_decoder_init_file_w", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10042:18
        { ("ma_decoder_uninit", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10047:18
        { ("ma_decoder_read_pcm_frames", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10054:18
        { ("ma_decoder_seek_to_pcm_frame", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10061:18
        { ("ma_decoder_get_data_format", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10066:18
        { ("ma_decoder_get_data_format", "pFormat"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10066:18
        { ("ma_decoder_get_cursor_in_pcm_frames", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10071:18
        { ("ma_decoder_get_length_in_pcm_frames", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10087:18
        { ("ma_decoder_get_available_frames", "pDecoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10098:18
        { ("ma_decode_from_vfs", "ppPCMFramesOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10104:18
        { ("ma_decode_file", "ppPCMFramesOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10105:18
        { ("ma_decode_memory", "ppPCMFramesOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10106:18
        { ("ma_encoder_init", "pEncoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10159:18
        { ("ma_encoder_init_vfs", "pEncoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10160:18
        { ("ma_encoder_init_vfs_w", "pEncoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10161:18
        { ("ma_encoder_init_file", "pEncoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10162:18
        { ("ma_encoder_init_file_w", "pEncoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10163:18
        { ("ma_encoder_uninit", "pEncoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10164:13
        { ("ma_encoder_write_pcm_frames", "pEncoder"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10165:18
        { ("ma_noise_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10284:18
        { ("ma_resource_manager_init", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10542:18
        { ("ma_resource_manager_uninit", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10543:13
        { ("ma_resource_manager_get_log", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10544:16
        { ("ma_resource_manager_register_file", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10547:18
        { ("ma_resource_manager_register_file_w", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10548:18
        { ("ma_resource_manager_register_decoded_data", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10549:18
        { ("ma_resource_manager_register_decoded_data_w", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10550:18
        { ("ma_resource_manager_register_encoded_data", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10551:18
        { ("ma_resource_manager_register_encoded_data_w", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10552:18
        { ("ma_resource_manager_unregister_file", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10553:18
        { ("ma_resource_manager_unregister_file_w", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10554:18
        { ("ma_resource_manager_unregister_data", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10555:18
        { ("ma_resource_manager_unregister_data_w", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10556:18
        { ("ma_resource_manager_data_buffer_init_ex", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10559:18
        { ("ma_resource_manager_data_buffer_init_ex", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10559:18
        { ("ma_resource_manager_data_buffer_init", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10560:18
        { ("ma_resource_manager_data_buffer_init", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10560:18
        { ("ma_resource_manager_data_buffer_init_w", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10561:18
        { ("ma_resource_manager_data_buffer_init_w", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10561:18
        { ("ma_resource_manager_data_buffer_init_copy", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10562:18
        { ("ma_resource_manager_data_buffer_init_copy", "pExistingDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10562:18
        { ("ma_resource_manager_data_buffer_init_copy", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10562:18
        { ("ma_resource_manager_data_buffer_uninit", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10563:18
        { ("ma_resource_manager_data_buffer_read_pcm_frames", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10564:18
        { ("ma_resource_manager_data_buffer_seek_to_pcm_frame", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10565:18
        { ("ma_resource_manager_data_buffer_get_data_format", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10566:18
        { ("ma_resource_manager_data_buffer_get_data_format", "pFormat"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10566:18
        { ("ma_resource_manager_data_buffer_get_cursor_in_pcm_frames", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10567:18
        { ("ma_resource_manager_data_buffer_get_length_in_pcm_frames", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10568:18
        { ("ma_resource_manager_data_buffer_result", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10569:18
        { ("ma_resource_manager_data_buffer_set_looping", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10570:18
        { ("ma_resource_manager_data_buffer_is_looping", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10571:18
        { ("ma_resource_manager_data_buffer_get_available_frames", "pDataBuffer"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10572:18
        { ("ma_resource_manager_data_stream_init_ex", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10575:18
        { ("ma_resource_manager_data_stream_init_ex", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10575:18
        { ("ma_resource_manager_data_stream_init", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10576:18
        { ("ma_resource_manager_data_stream_init", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10576:18
        { ("ma_resource_manager_data_stream_init_w", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10577:18
        { ("ma_resource_manager_data_stream_init_w", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10577:18
        { ("ma_resource_manager_data_stream_uninit", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10578:18
        { ("ma_resource_manager_data_stream_read_pcm_frames", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10579:18
        { ("ma_resource_manager_data_stream_seek_to_pcm_frame", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10580:18
        { ("ma_resource_manager_data_stream_get_data_format", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10581:18
        { ("ma_resource_manager_data_stream_get_data_format", "pFormat"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10581:18
        { ("ma_resource_manager_data_stream_get_cursor_in_pcm_frames", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10582:18
        { ("ma_resource_manager_data_stream_get_length_in_pcm_frames", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10583:18
        { ("ma_resource_manager_data_stream_result", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10584:18
        { ("ma_resource_manager_data_stream_set_looping", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10585:18
        { ("ma_resource_manager_data_stream_is_looping", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10586:18
        { ("ma_resource_manager_data_stream_get_available_frames", "pDataStream"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10587:18
        { ("ma_resource_manager_data_source_init_ex", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10590:18
        { ("ma_resource_manager_data_source_init_ex", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10590:18
        { ("ma_resource_manager_data_source_init", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10591:18
        { ("ma_resource_manager_data_source_init", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10591:18
        { ("ma_resource_manager_data_source_init_w", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10592:18
        { ("ma_resource_manager_data_source_init_w", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10592:18
        { ("ma_resource_manager_data_source_init_copy", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10593:18
        { ("ma_resource_manager_data_source_init_copy", "pExistingDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10593:18
        { ("ma_resource_manager_data_source_init_copy", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10593:18
        { ("ma_resource_manager_data_source_uninit", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10594:18
        { ("ma_resource_manager_data_source_read_pcm_frames", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10595:18
        { ("ma_resource_manager_data_source_seek_to_pcm_frame", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10596:18
        { ("ma_resource_manager_data_source_get_data_format", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10597:18
        { ("ma_resource_manager_data_source_get_data_format", "pFormat"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10597:18
        { ("ma_resource_manager_data_source_get_cursor_in_pcm_frames", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10598:18
        { ("ma_resource_manager_data_source_get_length_in_pcm_frames", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10599:18
        { ("ma_resource_manager_data_source_result", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10600:18
        { ("ma_resource_manager_data_source_set_looping", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10601:18
        { ("ma_resource_manager_data_source_is_looping", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10602:18
        { ("ma_resource_manager_data_source_get_available_frames", "pDataSource"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10603:18
        { ("ma_resource_manager_post_job", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10606:18
        { ("ma_resource_manager_post_job", "pJob"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10606:18
        { ("ma_resource_manager_post_job_quit", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10607:18
        { ("ma_resource_manager_next_job", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10608:18
        { ("ma_resource_manager_next_job", "pJob"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10608:18
        { ("ma_resource_manager_process_job", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10609:18
        { ("ma_resource_manager_process_job", "pJob"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10609:18
        { ("ma_resource_manager_process_next_job", "pResourceManager"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10610:18
        { ("ma_node_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10794:18
        { ("ma_node_graph_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10844:18
        { ("ma_node_graph_uninit", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10845:13
        { ("ma_node_graph_get_endpoint", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10846:17
        { ("ma_node_graph_read_pcm_frames", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10847:18
        { ("ma_node_graph_get_channels", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10848:18
        { ("ma_node_graph_get_time", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10849:18
        { ("ma_node_graph_set_time", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10850:18
        { ("ma_node_graph_get_processing_size_in_frames", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10851:18
        { ("ma_data_source_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10871:18
        { ("ma_splitter_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10893:18
        { ("ma_biquad_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10915:18
        { ("ma_lpf_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10938:18
        { ("ma_hpf_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10961:18
        { ("ma_bpf_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10984:18
        { ("ma_notch_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11007:18
        { ("ma_peak_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11030:18
        { ("ma_loshelf_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11053:18
        { ("ma_hishelf_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11076:18
        { ("ma_delay_node_init", "pNodeGraph"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11096:18
        { ("ma_engine_node_get_heap_size", "pHeapSizeInBytes"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11200:18
        { ("ma_engine_init", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11344:18
        { ("ma_engine_uninit", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11345:13
        { ("ma_engine_read_pcm_frames", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11346:18
        { ("ma_engine_get_node_graph", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11347:23
        { ("ma_engine_get_node_graph", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11347:23
        { ("ma_engine_get_resource_manager", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11349:29
        { ("ma_engine_get_resource_manager", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11349:29
        { ("ma_engine_get_device", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11351:19
        { ("ma_engine_get_device", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11351:19
        { ("ma_engine_get_log", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11352:16
        { ("ma_engine_get_endpoint", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11353:17
        { ("ma_engine_get_time_in_pcm_frames", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11354:18
        { ("ma_engine_get_time_in_milliseconds", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11355:18
        { ("ma_engine_set_time_in_pcm_frames", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11356:18
        { ("ma_engine_set_time_in_milliseconds", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11357:18
        { ("ma_engine_get_time", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11358:18
        { ("ma_engine_set_time", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11359:18
        { ("ma_engine_get_channels", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11360:18
        { ("ma_engine_get_sample_rate", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11361:18
        { ("ma_engine_start", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11363:18
        { ("ma_engine_stop", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11364:18
        { ("ma_engine_set_volume", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11365:18
        { ("ma_engine_get_volume", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11366:14
        { ("ma_engine_set_gain_db", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11367:18
        { ("ma_engine_get_gain_db", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11368:14
        { ("ma_engine_get_listener_count", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11370:18
        { ("ma_engine_find_closest_listener", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11371:18
        { ("ma_engine_listener_set_position", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11372:13
        { ("ma_engine_listener_get_position", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11373:17
        { ("ma_engine_listener_set_direction", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11374:13
        { ("ma_engine_listener_get_direction", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11375:17
        { ("ma_engine_listener_set_velocity", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11376:13
        { ("ma_engine_listener_get_velocity", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11377:17
        { ("ma_engine_listener_set_cone", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11378:13
        { ("ma_engine_listener_get_cone", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11379:13
        { ("ma_engine_listener_get_cone", "pInnerAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11379:13
        { ("ma_engine_listener_get_cone", "pOuterAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11379:13
        { ("ma_engine_listener_get_cone", "pOuterGain"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11379:13
        { ("ma_engine_listener_set_world_up", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11380:13
        { ("ma_engine_listener_get_world_up", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11381:17
        { ("ma_engine_listener_set_enabled", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11382:13
        { ("ma_engine_listener_is_enabled", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11383:18
        { ("ma_engine_play_sound_ex", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11386:18
        { ("ma_engine_play_sound", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11387:18
        { ("ma_sound_init_from_file", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11391:18
        { ("ma_sound_init_from_file", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11391:18
        { ("ma_sound_init_from_file_w", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11392:18
        { ("ma_sound_init_from_file_w", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11392:18
        { ("ma_sound_init_copy", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11393:18
        { ("ma_sound_init_copy", "pExistingSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11393:18
        { ("ma_sound_init_copy", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11393:18
        { ("ma_sound_init_from_data_source", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11395:18
        { ("ma_sound_init_from_data_source", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11395:18
        { ("ma_sound_init_ex", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11396:18
        { ("ma_sound_init_ex", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11396:18
        { ("ma_sound_uninit", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11397:13
        { ("ma_sound_get_engine", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11398:19
        { ("ma_sound_get_engine", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11398:19
        { ("ma_sound_get_data_source", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11399:24
        { ("ma_sound_start", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11400:18
        { ("ma_sound_stop", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11401:18
        { ("ma_sound_stop_with_fade_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11402:18
        { ("ma_sound_stop_with_fade_in_milliseconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11403:18
        { ("ma_sound_reset_start_time", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11404:13
        { ("ma_sound_reset_stop_time", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11405:13
        { ("ma_sound_reset_fade", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11406:13
        { ("ma_sound_reset_stop_time_and_fade", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11407:13
        { ("ma_sound_set_volume", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11408:13
        { ("ma_sound_get_volume", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11409:14
        { ("ma_sound_set_pan", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11410:13
        { ("ma_sound_get_pan", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11411:14
        { ("ma_sound_set_pan_mode", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11412:13
        { ("ma_sound_get_pan_mode", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11413:20
        { ("ma_sound_set_pitch", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11414:13
        { ("ma_sound_get_pitch", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11415:14
        { ("ma_sound_set_spatialization_enabled", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11416:13
        { ("ma_sound_is_spatialization_enabled", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11417:18
        { ("ma_sound_set_pinned_listener_index", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11418:13
        { ("ma_sound_get_pinned_listener_index", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11419:18
        { ("ma_sound_get_listener_index", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11420:18
        { ("ma_sound_get_direction_to_listener", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11421:17
        { ("ma_sound_set_position", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11422:13
        { ("ma_sound_get_position", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11423:17
        { ("ma_sound_set_direction", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11424:13
        { ("ma_sound_get_direction", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11425:17
        { ("ma_sound_set_velocity", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11426:13
        { ("ma_sound_get_velocity", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11427:17
        { ("ma_sound_set_attenuation_model", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11428:13
        { ("ma_sound_get_attenuation_model", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11429:29
        { ("ma_sound_set_positioning", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11430:13
        { ("ma_sound_get_positioning", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11431:23
        { ("ma_sound_set_rolloff", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11432:13
        { ("ma_sound_get_rolloff", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11433:14
        { ("ma_sound_set_min_gain", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11434:13
        { ("ma_sound_get_min_gain", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11435:14
        { ("ma_sound_set_max_gain", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11436:13
        { ("ma_sound_get_max_gain", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11437:14
        { ("ma_sound_set_min_distance", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11438:13
        { ("ma_sound_get_min_distance", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11439:14
        { ("ma_sound_set_max_distance", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11440:13
        { ("ma_sound_get_max_distance", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11441:14
        { ("ma_sound_set_cone", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11442:13
        { ("ma_sound_get_cone", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11443:13
        { ("ma_sound_get_cone", "pInnerAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11443:13
        { ("ma_sound_get_cone", "pOuterAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11443:13
        { ("ma_sound_get_cone", "pOuterGain"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11443:13
        { ("ma_sound_set_doppler_factor", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11444:13
        { ("ma_sound_get_doppler_factor", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11445:14
        { ("ma_sound_set_directional_attenuation_factor", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11446:13
        { ("ma_sound_get_directional_attenuation_factor", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11447:14
        { ("ma_sound_set_fade_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11448:13
        { ("ma_sound_set_fade_in_milliseconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11449:13
        { ("ma_sound_set_fade_start_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11450:13
        { ("ma_sound_set_fade_start_in_milliseconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11451:13
        { ("ma_sound_get_current_fade_volume", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11452:14
        { ("ma_sound_set_start_time_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11453:13
        { ("ma_sound_set_start_time_in_milliseconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11454:13
        { ("ma_sound_set_stop_time_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11455:13
        { ("ma_sound_set_stop_time_in_milliseconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11456:13
        { ("ma_sound_set_stop_time_with_fade_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11457:13
        { ("ma_sound_set_stop_time_with_fade_in_milliseconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11458:13
        { ("ma_sound_is_playing", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11459:18
        { ("ma_sound_get_time_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11460:18
        { ("ma_sound_get_time_in_milliseconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11461:18
        { ("ma_sound_set_looping", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11462:13
        { ("ma_sound_is_looping", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11463:18
        { ("ma_sound_at_end", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11464:18
        { ("ma_sound_seek_to_pcm_frame", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11465:18
        { ("ma_sound_seek_to_second", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11466:18
        { ("ma_sound_get_data_format", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11467:18
        { ("ma_sound_get_data_format", "pFormat"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11467:18
        { ("ma_sound_get_cursor_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11468:18
        { ("ma_sound_get_length_in_pcm_frames", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11469:18
        { ("ma_sound_get_cursor_in_seconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11470:18
        { ("ma_sound_get_cursor_in_seconds", "pCursor"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11470:18
        { ("ma_sound_get_length_in_seconds", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11471:18
        { ("ma_sound_get_length_in_seconds", "pLength"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11471:18
        { ("ma_sound_set_end_callback", "pSound"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11472:18
        { ("ma_sound_group_init", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11474:18
        { ("ma_sound_group_init_ex", "pEngine"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11475:18
        { ("ma_sound_group_get_engine", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11477:19
        { ("ma_sound_group_get_cone", "pInnerAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11515:13
        { ("ma_sound_group_get_cone", "pOuterAngleInRadians"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11515:13
        { ("ma_sound_group_get_cone", "pOuterGain"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11515:13
        { ("ma_version_string", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4513:20
        { ("ma_log_post", "pMessage"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4586:18
        { ("ma_log_postf", "pFormat"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:4588:18
        { ("ma_channel_map_to_string", "pBufferOut"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5804:15
        { ("ma_channel_position_to_string", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:5809:20
        { ("ma_result_description", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6120:20
        { ("ma_get_format_name", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6155:20
        { ("ma_log_level_to_string", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:6176:20
        { ("ma_device_get_name", "pName"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9141:18
        { ("ma_get_backend_name", "__return"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9658:20
        { ("ma_get_backend_from_name", "pBackendName"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9663:18
        { ("ma_vfs_open", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9908:18
        { ("ma_vfs_open_and_read_file", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:9916:18
        { ("ma_decoder_init_vfs", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10039:18
        { ("ma_decoder_init_file", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10041:18
        { ("ma_decode_from_vfs", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10104:18
        { ("ma_decode_file", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10105:18
        { ("ma_encoder_init_vfs", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10160:18
        { ("ma_encoder_init_file", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10162:18
        { ("ma_resource_manager_register_file", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10547:18
        { ("ma_resource_manager_register_decoded_data", "pName"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10549:18
        { ("ma_resource_manager_register_encoded_data", "pName"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10551:18
        { ("ma_resource_manager_unregister_file", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10553:18
        { ("ma_resource_manager_unregister_data", "pName"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10555:18
        { ("ma_resource_manager_data_buffer_init", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10560:18
        { ("ma_resource_manager_data_stream_init", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10576:18
        { ("ma_resource_manager_data_source_init", "pName"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:10591:18
        { ("ma_engine_play_sound_ex", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11386:18
        { ("ma_engine_play_sound", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11387:18
        { ("ma_sound_init_from_file", "pFilePath"), PointerFunctionDataIntent.Unknown }, // ../miniaudio/miniaudio.h:11391:18
    };

    internal static readonly Dictionary<string, string> ReturnedArrayCountParamNames = new()
    {

    };

    internal static readonly Dictionary<string, DelegateDefinition> DelegateDefinitions = new()
    {
        { "ma_log_callback_proc", new DelegateDefinition { ReturnType = "void", Parameters = [("void*", "pUserData"), ("uint", "level"), ("sbyte*", "pMessage")] } }, // ../miniaudio/miniaudio.h:4561:17
        { "ma_data_source_get_next_proc", new DelegateDefinition { ReturnType = "void*", Parameters = [("void*", "pDataSource")] } }, // ../miniaudio/miniaudio.h:5851:28
        { "ma_job_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("ma_job*", "pJob")] } }, // ../miniaudio/miniaudio.h:6395:22
        { "ma_device_notification_proc", new DelegateDefinition { ReturnType = "void", Parameters = [("ma_device_notification*", "pNotification")] } }, // ../miniaudio/miniaudio.h:6851:17
        { "ma_device_data_proc", new DelegateDefinition { ReturnType = "void", Parameters = [("ma_device*", "pDevice"), ("void*", "pOutput"), ("void*", "pInput"), ("uint", "frameCount")] } }, // ../miniaudio/miniaudio.h:6894:17
        { "ma_stop_proc", new DelegateDefinition { ReturnType = "void", Parameters = [("ma_device*", "pDevice")] } }, // ../miniaudio/miniaudio.h:6918:17
        { "ma_enum_devices_callback_proc", new DelegateDefinition { ReturnType = "uint", Parameters = [("ma_context*", "pContext"), ("ma_device_type", "deviceType"), ("ma_device_info*", "pInfo"), ("void*", "pUserData")] } }, // ../miniaudio/miniaudio.h:7206:22
        { "ma_read_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("void*", "pUserData"), ("void*", "pBufferOut"), ("nuint", "bytesToRead"), ("nuint*", "pBytesRead")] } }, // ../miniaudio/miniaudio.h:9928:22
        { "ma_seek_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("void*", "pUserData"), ("long", "offset"), ("ma_seek_origin", "origin")] } }, // ../miniaudio/miniaudio.h:9929:22
        { "ma_tell_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("void*", "pUserData"), ("long*", "pCursor")] } }, // ../miniaudio/miniaudio.h:9930:22
        { "ma_decoder_read_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("ma_decoder*", "pDecoder"), ("void*", "pBufferOut"), ("nuint", "bytesToRead"), ("nuint*", "pBytesRead")] } }, // ../miniaudio/miniaudio.h:9977:22
        { "ma_decoder_seek_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("ma_decoder*", "pDecoder"), ("long", "byteOffset"), ("ma_seek_origin", "origin")] } }, // ../miniaudio/miniaudio.h:9978:22
        { "ma_decoder_tell_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("ma_decoder*", "pDecoder"), ("long*", "pCursor")] } }, // ../miniaudio/miniaudio.h:9979:22
        { "ma_encoder_write_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("ma_encoder*", "pEncoder"), ("void*", "pBufferIn"), ("nuint", "bytesToWrite"), ("nuint*", "pBytesWritten")] } }, // ../miniaudio/miniaudio.h:10122:22
        { "ma_encoder_seek_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("ma_encoder*", "pEncoder"), ("long", "offset"), ("ma_seek_origin", "origin")] } }, // ../miniaudio/miniaudio.h:10123:22
        { "ma_encoder_init_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("ma_encoder*", "pEncoder")] } }, // ../miniaudio/miniaudio.h:10124:22
        { "ma_encoder_uninit_proc", new DelegateDefinition { ReturnType = "void", Parameters = [("ma_encoder*", "pEncoder")] } }, // ../miniaudio/miniaudio.h:10125:22
        { "ma_encoder_write_pcm_frames_proc", new DelegateDefinition { ReturnType = "ma_result", Parameters = [("ma_encoder*", "pEncoder"), ("void*", "pFramesIn"), ("ulong", "frameCount"), ("ulong*", "pFramesWritten")] } }, // ../miniaudio/miniaudio.h:10126:22
        { "ma_sound_end_proc", new DelegateDefinition { ReturnType = "void", Parameters = [("void*", "pUserData"), ("ma_sound*", "pSound")] } }, // ../miniaudio/miniaudio.h:11209:17
        { "ma_engine_process_proc", new DelegateDefinition { ReturnType = "void", Parameters = [("void*", "pUserData"), ("float*", "pFramesOut"), ("ulong", "frameCount")] } }, // ../miniaudio/miniaudio.h:11279:17
    };

    internal static readonly Dictionary<string, string[]> FlagEnumDefinitions = new()
    {

    };

    internal static readonly HashSet<string> FlagTypes = [];

    internal static readonly string[] DeniedTypes = [];
}
