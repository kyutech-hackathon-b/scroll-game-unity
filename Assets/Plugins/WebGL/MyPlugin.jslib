mergeInto(LibraryManager.library, {
  Score: function(score) {
    window.dispatchReactUnityEvent("Score",score);
  }
});