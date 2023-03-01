import bluetooth
from bluetooth.ble import DiscoveryService
"""BLE scan"""

def bluetoothLowEnergyScan():
    service = DiscoveryService()
    devices = service.discover(2)

    # for address, name in devices.items():
        # print("Name: {}, address: {}".format(name, address))
    return len(devices.items())


"""Simple Inquiry"""
# print("Performing inquiry...")

# nearby_devices = bluetooth.discover_devices(duration=8, lookup_names=True,
#                                             flush_cache=True, lookup_class=False)

# print("Found {} devices".format(len(nearby_devices)))

# for addr, name in nearby_devices:
#     try:
#         print("   {} - {}".format(addr, name))
#     except UnicodeEncodeError:
#         print("   {} - {}".format(addr, name.encode("utf-8", "replace")))





# import struct
# import sys

# import bluetooth
# import bluetooth._bluetooth as bluez  # low level bluetooth wrappers


"""Inquiry with RSSI"""
# def device_inquiry_with_with_rssi(sock):
#     # save current filter
#     print("NewCall")
#     old_filter = sock.getsockopt(bluez.SOL_HCI, bluez.HCI_FILTER, 14)

#     # perform a device inquiry on bluetooth device #0
#     # The inquiry should last 8 * 1.28 = 10.24 seconds
#     # before the inquiry is performed, bluez should flush its cache of
#     # previously discovered devices
#     flt = bluez.hci_filter_new()
#     bluez.hci_filter_all_events(flt)
#     bluez.hci_filter_set_ptype(flt, bluez.HCI_EVENT_PKT)
#     sock.setsockopt(bluez.SOL_HCI, bluez.HCI_FILTER, flt)

#     duration = 4
#     max_responses = 255
#     cmd_pkt = struct.pack("BBBBB", 0x33, 0x8b, 0x9e, duration, max_responses)
#     bluez.hci_send_cmd(sock, bluez.OGF_LINK_CTL, bluez.OCF_INQUIRY, cmd_pkt)

#     results = []

#     while True:
#         pkt = sock.recv(255)
#         ptype, event, plen = struct.unpack("BBB", pkt[:3])
#         print("Event: {}".format(event))
#         if event == bluez.EVT_INQUIRY_RESULT_WITH_RSSI:
#             pkt = pkt[3:]
#             nrsp = bluetooth.get_byte(pkt[0])
#             for i in range(nrsp):
#                 addr = bluez.ba2str(pkt[1+6*i:1+6*i+6])
#                 rssi = bluetooth.byte_to_signed_int(
#                     bluetooth.get_byte(pkt[1 + 13 * nrsp + i]))
#                 results.append((addr, rssi))
#                 print("[{}] RSSI: {}".format(addr, rssi))
#         elif event == bluez.EVT_INQUIRY_COMPLETE:
#             break
#         elif event == bluez.EVT_CMD_STATUS:
#             status, ncmd, opcode = struct.unpack("BBH", pkt[3:7])
#             if status:
#                 print("Uh oh...")
#                 printpacket(pkt[3:7])
#                 break
#         elif event == bluez.EVT_INQUIRY_RESULT:
#             pkt = pkt[3:]
#             nrsp = bluetooth.get_byte(pkt[0])
#             for i in range(nrsp):
#                 addr = bluez.ba2str(pkt[1+6*i:1+6*i+6])
#                 results.append((addr, -1))
#                 print("[{}] (no RRSI)".format(addr))
#         else:
#             print("Unrecognized packet type 0x{:02x}.".format(ptype))

#     # restore old filter
#     sock.setsockopt(bluez.SOL_HCI, bluez.HCI_FILTER, old_filter)

#     return results

# dev_id = 0
# try:
#     sock = bluez.hci_open_dev(dev_id)
# except:
#     print("Error accessing bluetooth device.")
#     sys.exit(1)

# print(device_inquiry_with_with_rssi(sock))

