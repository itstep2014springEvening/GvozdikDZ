TEMPLATE = app
CONFIG += console
CONFIG -= app_bundle
CONFIG -= qt
CONFIG += c++11

SOURCES += main.cpp \
    set.cpp

include(deployment.pri)
qtcAddDeployment()

HEADERS += \
    set.h

